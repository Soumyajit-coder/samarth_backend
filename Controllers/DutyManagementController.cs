using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DTO;
using samarth_backend.Helper;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace samarth_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DutyManagementController : ControllerBase
    {
        private readonly IDutyManagementService _dutyManagementService;
        private APIResponse _apiResponse;

        public DutyManagementController(IDutyManagementService dutyManagementService)
        {
            _dutyManagementService = dutyManagementService;
            _apiResponse = new();
        }

        [HttpGet]
        [Route("get-permission-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetPermissionList()
        {
            try
            {
                var permissionList = await _dutyManagementService.GetAllPermissionAsync();
                if (permissionList == null)
                {
                    _apiResponse.Message.Add("No Data Found");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return _apiResponse;
                }
                _apiResponse.Data = permissionList;
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
        [Route("add-permission")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> AddPermission([FromBody] AddPermissionDTO dto)
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
                var permissionId = await _dutyManagementService.AddPermissionAsync(dto);
                if (permissionId > 0)
                {
                    _apiResponse.Message.Add("Permission added successfully!");
                    _apiResponse.Status = true;
                    _apiResponse.StatusCode = HttpStatusCode.Created;
                    return _apiResponse;
                } else
                {
                    _apiResponse.Message.Add("Failed to add permission.");
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
        [Route("search-by-name")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> SearchPermissionByName(string name)
        {
            try
            {
                var permissionName = await _dutyManagementService.GetPermissionDetailsByNameAsync(name);
                if (permissionName == null)
                {
                    _apiResponse.Message.Add($"No permision has found with {name}");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return _apiResponse;
                }
                _apiResponse.Data = permissionName;
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
        [Route("update-permission/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> UpdatePermissionAsync(long id, updatePermissionDTO dto)
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
                var updatePermission = await _dutyManagementService.UpdatePermissionAsync(id, dto);
                if (updatePermission)
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
