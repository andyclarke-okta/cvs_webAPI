using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using webAPI_allDemo_core31.Models;


namespace webAPI_allDemo_core31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventHookController : ControllerBase
    {

        private readonly ILogger<EventHookController> _logger;

        public EventHookController(ILogger<EventHookController> logger)
        {
            _logger = logger;
        }

        [EnableCors("AllowAll")]
        [HttpGet]
        [Route("profileupdate")]
        public IActionResult validateHook()
        {
            JObject jsonObject = null;
            string authHeader = Request.Headers["Authorization"];
            string verifyHeader = Request.Headers["X-Okta-Verification-Challenge"];

            if (authHeader == "mySharedSecret")
            {
                jsonObject = new JObject(
                    new JProperty("verification", verifyHeader)
                    );
            }
            else
            {
                return Unauthorized();
            }

            return Ok(jsonObject);
        }


        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("profileupdate")]
        public IActionResult Profileupdate([FromBody]EventHookRequest request)
        {
            string authHeader = Request.Headers["Authorization"];

            if (authHeader == "mySharedSecret")
            {
                //send process to async service
                //response should be sent quickly
            }
            else
            {
                return Unauthorized();
            }



            return NoContent();
        }


















    }
}