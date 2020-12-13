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

namespace webAPI_allDemo_core31.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private readonly ILogger<ValuesController> _logger;

        public ValuesController(ILogger<ValuesController> logger)
        {
            _logger = logger;
        }



        //[EnableCors("AllowAll")]
        [EnableCors()]
        [HttpGet]
        [Route("unprotected")]
        public IActionResult NotSecured()
        {

            string today = DateTime.Now.ToString();

            JObject message1 = new JObject(
                new JProperty("date", today),
                new JProperty("text", "Web Api unprotected endpoint")
                );


            JObject message2 = new JObject(
                new JProperty("date", today),
                new JProperty("text", "I am robot")
                );

            JArray messages = new JArray();
            messages.Add(message1);
            messages.Add(message2);

            JObject jsonObject = new JObject(
                    new JProperty("messages", messages)
                    );

            return Ok(jsonObject);

           // return this.Ok("Web Api unprotected endpoint, SUCCESS");
        }

        [Authorize]
        [EnableCors()]
        [HttpGet]
        [Route("protected")]
        public IActionResult Secured()
        {

            string today = DateTime.Now.ToString();

            var myLogin = this.User.Claims.FirstOrDefault(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier").Value;
            var myAud = this.User.Claims.FirstOrDefault(x => x.Type == "aud").Value;

            JObject message1 = new JObject(
                new JProperty("key", "Web Api protected endpoint"),
                new JProperty("value", "I am robot")
                );

            JObject message2 = new JObject(
                new JProperty("key", "Date"),
                new JProperty("value", today)
                );

            JObject message3 = new JObject(
                new JProperty("key", "Login"),
                new JProperty("value", myLogin)
                );

            JObject message4 = new JObject(
                new JProperty("key", "Audience"),
                new JProperty("value", myAud)
                );


            JArray messages = new JArray();
                messages.Add(message1);
                messages.Add(message2);
                messages.Add(message3);
                messages.Add(message4);

            JObject jsonObject = new JObject(
                    new JProperty("messages", messages)
                    );

            return Ok(jsonObject);

            //return this.Ok("Web Api protected endpoint, SUCCESS");
        }





        [EnableCors()]
        [HttpGet]
        [Route("GetString")]
        public IActionResult GetString()
        {


            return this.Ok("Values Controller");
        }


    }
}