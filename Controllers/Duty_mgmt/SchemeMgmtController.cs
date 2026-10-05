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
    public class SchemeMgmtController : ControllerBase
    {
        private readonly ISchemeMgmtService _schemeMgmtService;
        private APIResponse _apiResponse;

        public SchemeMgmtController(ISchemeMgmtService schemeMgmtService)
        {
            _schemeMgmtService = schemeMgmtService;
            _apiResponse = new();
        }

        [HttpGet]
        [Route("Get-Schemes-List")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetSchemesListAsync()
        {
            try
            {
                var schemesList = await _schemeMgmtService.GetAllSchemesAsync();
                if (schemesList == null || !schemesList.Any())
                {
                    _apiResponse.Message.Add("No Data Found");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return _apiResponse;
                }
                _apiResponse.Data = schemesList;
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

        [HttpGet]
        [Route("Get-Scheme-Details-by-Id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> GetSchemeDetailsByIdAsync([FromBody] long schemeId)
        {
            try
            {
                var schemeDetails = await _schemeMgmtService.GetSchemeByIdAsync(schemeId);
                if (schemeDetails == null)
                {
                    _apiResponse.Message.Add("No Data Found");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.NotFound;
                    return _apiResponse;
                }
                _apiResponse.Data = schemeDetails;
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
        [Route("Add-Scheme-Details")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> AddSchemeDetailsAsync([FromBody] SchemeMgmtDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    _apiResponse.Message.Add("Invalid data provided");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return _apiResponse;
                }
                var createdSchemeId = await _schemeMgmtService.CreateSchemeAsync(dto);
                if (createdSchemeId != null)
                {
                    _apiResponse.Message.Add("Scheme Add Successfully!");
                    _apiResponse.Status = true;
                    _apiResponse.StatusCode = HttpStatusCode.Created;
                    return _apiResponse;
                }
                _apiResponse.Message.Add("Something went wrong!");
                _apiResponse.Status = false;
                _apiResponse.StatusCode = HttpStatusCode.Created;
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
        [Route("Update-Scheme-Details/{id}")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> UpdateSchemeDetailsAsync(long id, [FromBody] updateSchemeDTO dto)
        {
            try
            {
                if (dto == null)
                {
                    _apiResponse.Message.Add("Invalid data provided");
                    _apiResponse.Status = false;
                    _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                    return _apiResponse;
                }
                var updatedScheme = await _schemeMgmtService.UpdateSchemeAsync(id, dto);
                if (updatedScheme != null)
                {
                    _apiResponse.Message.Add("Scheme Updated Successfully!");
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
                _apiResponse.StatusCode = HttpStatusCode.BadRequest;
                return _apiResponse;
            }
        }
    }
}
