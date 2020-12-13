using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webAPI_allDemo_core31.Models;
using Microsoft.Extensions.Logging;

namespace webAPI_allDemo_core31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdProofController : ControllerBase
    {

        private readonly ILogger<IdProofController> _logger;

        public IdProofController(ILogger<IdProofController> logger)
        {
            _logger = logger;
        }

        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("requestapproval")]
        public IActionResult RequestApproval([FromBody]IdProofRequest request)
        {
            string IsApproved = "true";

            return Ok(IsApproved);
        }


        [EnableCors("AllowAll")]
        [HttpGet]
        [Route("GetString")]
        public IEnumerable<string> GetString()
        {
            return new string[] { "IdProofing", "Demo" };
        }


    }
}