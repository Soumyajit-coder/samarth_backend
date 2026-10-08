using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using samarth_backend.BAL.Interfaces;
using samarth_backend.DTO;
using samarth_backend.Helper;

namespace samarth_backend.Controllers.Duty_mgmt
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeMasterController : ControllerBase
    {
        private readonly IOfficeMasterService _officeMasterService;
        private APIResponse _apiResponse;

        public OfficeMasterController(IOfficeMasterService officeMasterService)
        {
            _officeMasterService = officeMasterService;
            _apiResponse = new();
        }

        [HttpGet]
        [Route("get-office-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetOfficeList(long? dist_code = null, long? block_code = null, long? subDiv_code = null)
        {
            try
            {
                var officeList = await _officeMasterService.GetAllOfficesAsync(dist_code, block_code, subDiv_code);
                if (officeList == null)
                {
                    _apiResponse.Message.Add("No Data Found");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return _apiResponse;
                }
                _apiResponse.Data = officeList;
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
        [Route("Add-Office-Master")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateOfficeMaster([FromBody] AddOfficeMasterDTO dto)
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
                var newOfficeId = await _officeMasterService.AddOfficeAsync(dto);
                if (newOfficeId > 0)
                {
                    _apiResponse.Message.Add("Office added successfully!");
                    _apiResponse.Status = true;
                    _apiResponse.StatusCode = HttpStatusCode.Created;
                    return _apiResponse;
                }
                _apiResponse.Message.Add("Failed to add office");
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
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
        [Route("Update-Office-Master/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> UpdateOfficeMaster(long id, [FromBody] updateOfficeMasterDTO dto)
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
                var isUpdated = await _officeMasterService.UpdateOfficeAsync(id, dto);
                if (isUpdated)
                {
                    _apiResponse.Message.Add("Office updated successfully!");
                    _apiResponse.Status = true;
                    _apiResponse.StatusCode = HttpStatusCode.OK;
                    return _apiResponse;
                }
                else
                {
                    _apiResponse.Message.Add("Failed to update office. Office not found.");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
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
    }
}
