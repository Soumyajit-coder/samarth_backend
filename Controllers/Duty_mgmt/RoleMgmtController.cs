using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DTO;
using samarth_backend.Helper;

namespace samarth_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleMgmtController : ControllerBase
    {
        private readonly IRoleMgmtService _roleMgmtService;
        private APIResponse _apiResponse;

        public RoleMgmtController(IRoleMgmtService roleMgmtService)
        {
            _roleMgmtService = roleMgmtService;
            _apiResponse = new();
        }

        [HttpGet]
        [Route("Get-role-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetRoleListAsync()
        {
            try
            {
                var roleList = await _roleMgmtService.GetAllRolesAsync();
                if (roleList == null || !roleList.Any())
                {
                    _apiResponse.Message.Add("No Data Found");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return _apiResponse;
                }
                _apiResponse.Data = roleList;
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

        [HttpPost]
        [Route("Add-role-details")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> AddRoleDetailsAsync([FromBody] RoleMgmtDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    _apiResponse.Message.Add("Request body is null");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return _apiResponse;
                }
                var createdRoleId = await _roleMgmtService.AddRoleAsync(dto);
                if (createdRoleId > 0)
                {
                    _apiResponse.Message.Add("Role added successfully");
                    _apiResponse.Status = true;
                    _apiResponse.StatusCode = HttpStatusCode.Created;
                    return _apiResponse;
                } else
                {
                    _apiResponse.Message.Add("Failed to add role");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return _apiResponse;
                }
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

        [HttpGet]
        [Route("Get-role-details-by-name")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetRoleDetailsByNameAsync(string name)
        {
            try
            {
                var roleDetails = await _roleMgmtService.GetRoleDetailsByNameAsync(name);
                if (roleDetails == null)
                {
                    _apiResponse.Message.Add($"No Role found with {name}");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return _apiResponse;
                }
                _apiResponse.Data = roleDetails;
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
        [Route("update-role-detals/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> UpdateRoleDetailsAsync(long id, [FromBody] UpdateRoleDetailsDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    _apiResponse.Message.Add("Something went wrong");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return _apiResponse;
                }
                var isUpdated = await _roleMgmtService.UpdateRoleAsync(id, dto);
                if (isUpdated)
                {
                    _apiResponse.Message.Add($"Update successfully done of ID: {id}");
                    _apiResponse.Status = true;
                    _apiResponse.StatusCode = HttpStatusCode.OK;
                    return _apiResponse;
                }
                _apiResponse.Message.Add("Something went wrong!!");
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.InternalServerError;
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
    }
}
