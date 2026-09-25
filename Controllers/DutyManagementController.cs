using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using samarth_backend.BAL.Interfaces;
using System.IdentityModel.Tokens.Jwt;
using System.Net;

namespace samarth_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DutyManagementController : ControllerBase
    {
        private readonly IDutyManagementService _dutyManagementService;

    }
}
