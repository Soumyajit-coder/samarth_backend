using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DTO;
using samarth_backend.Helper;

namespace jb_dot_net.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IUsersService _userService;
        private readonly ICaptchaService _captchaService;
        private readonly IOtpService _otpService;
        private readonly IConfiguration _config;
        private APIResponse _apiResponse;
        public AuthenticationController(IUsersService usersService, ICaptchaService captchaService, IOtpService otpService, IConfiguration config)
        {
            _userService = usersService;
            _captchaService = captchaService;
            _otpService = otpService;
            _apiResponse = new();
            _config = config;
        }
        [HttpGet]
        [Route("captcha")]
        public async Task<ActionResult<APIResponse>> GetCaptcha()
        {
            try
            {
                var captchaResponse = await _captchaService.GenerateCaptchaAsync();
                _apiResponse.Data = captchaResponse;
                _apiResponse.Status = true;
                _apiResponse.StatusCode = HttpStatusCode.OK;
                return _apiResponse;
            }
            catch (Exception ex)
            {
                string detailedError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Message.Add(detailedError);
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                return _apiResponse;
            }

        }
        [HttpPut]
        [Route("forget-password")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> ForgetPassword(string mobile_no, [FromBody] UserForgetPasswordDTO dto)
        {
            try
            {
                var userDetails = await _userService.GetUserToAuthenticate(mobile_no);
                if (userDetails == null)
                {
                    _apiResponse.Message.Add("User not avaliable");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return _apiResponse;
                }
                bool updatePassword = await _userService.UserForgetPassword(mobile_no, dto);
                if (updatePassword)
                {
                    _apiResponse.Message.Add("Password has changed");
                    _apiResponse.Status = true;
                    _apiResponse.StatusCode = HttpStatusCode.OK;
                    return _apiResponse;
                }
                _apiResponse.Message.Add("Something went wrong!");
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.InternalServerError;
                return _apiResponse;
            }
            catch (Exception ex)
            {
                string detailedError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Message.Add(detailedError);
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.InternalServerError;
                return _apiResponse;
            }
        }
        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<APIResponse>> userLogin([FromBody] UserLoginDTO dto)
        {
            try
            {
                var isCaptchaValid = await _captchaService.ValidateCaptchaAsync(dto.CaptchaId, dto.CaptchaInput);
                if (!isCaptchaValid)
                {
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.Message.Add("Invalid captcha.");
                    return _apiResponse;
                }
                var user = await _userService.GetUserToAuthenticate(dto.MobileNo);
                if (user == null)
                {
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    _apiResponse.Message.Add("User not found.");
                    return _apiResponse;
                }
                // Assuming you have a method to verify the password
                bool isPasswordValid = _userService.VerifyPasswordHash(dto.Password, user.Password);
                if (isPasswordValid)
                {
                    string otp = await _otpService.GenerateAndStoreOtpAsync(dto.MobileNo);
                    _apiResponse.Message.Add("Credentials valid. OTP sent to registered mobile number.");
                    _apiResponse.Data = new { otp = otp }; // Note: In production, do not return OTP here. Send via SMS.
                    _apiResponse.Status = true;
                    _apiResponse.StatusCode = HttpStatusCode.OK;
                    return _apiResponse;
                }
                // If everything is valid, return success response
                _apiResponse.Message.Add("Login Failed");
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                return _apiResponse;
            }
            catch (Exception ex)
            {
                string detailedError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Message.Add(detailedError);
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.InternalServerError;
                return _apiResponse;
            }
        }

        [HttpPost]
        [Route("verify-otp")]
        public async Task<ActionResult<APIResponse>> verifyOtp([FromBody] UserVerifyOtpDTO dto)
        {
            try
            {
                var isOtpValid = await _otpService.ValidateOtpAsync(dto.MobileNo, dto.Otp);
                if (!isOtpValid)
                {
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    _apiResponse.Message.Add("Invalid or expired OTP.");
                    return _apiResponse;
                }

                var user = await _userService.GetUserToAuthenticate(dto.MobileNo);
                if (user == null)
                {
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    _apiResponse.Message.Add("User not found.");
                    return _apiResponse;
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.DesignationId.ToString()),
                    new Claim(ClaimTypes.MobilePhone, user.MobileNo.ToString()),
                    new Claim(ClaimTypes.Name, user.Name.ToString()),
                    new Claim("DistrictCode", user.DistrictCode.ToString())
                };
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config.GetSection("Auth:TokenKey").Value));
                var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokenOptions = new JwtSecurityToken(
                    issuer: _config.GetSection("Auth:Issuer").Value,
                    audience: _config.GetSection("Auth:Audience").Value,
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(3),
                    signingCredentials: signingCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
                _apiResponse.Message.Add("Login Successful");
                _apiResponse.Data = tokenString;
                _apiResponse.Status = true;
                _apiResponse.StatusCode = HttpStatusCode.OK;
                return _apiResponse;
            }
            catch (Exception ex)
            {
                string detailedError = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                _apiResponse.Message.Add(detailedError);
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.InternalServerError;
                return _apiResponse;
            }
        }
    }
}
