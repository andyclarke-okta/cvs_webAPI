using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using webAPI_allDemo_core31.Models;
using Microsoft.Extensions.Logging;

namespace webAPI_allDemo_core31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InlineHookController : ControllerBase
    {

        private readonly ILogger<InlineHookController> _logger;

        public InlineHookController(ILogger<InlineHookController> logger)
        {
            _logger = logger;
        }

        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("password")]
        public IActionResult PasswordHook([FromBody] PasswordHookRequest request)
        {

            ////put any additional processing here, keep latency to a minimum


            //option 2 on the fly with JSON
            JObject value1 = new JObject(
                new JProperty("credential", "VERIFIED")
                );

            JObject command1 = new JObject(
                new JProperty("type", "com.okta.action.update"),
                new JProperty("value", value1)
                );


            JArray commands = new JArray();
            commands.Add(command1);


            JObject debug = new JObject(
               new JProperty("executionTimeMillis", 200)
               );


            JObject jsonObject = new JObject(
                new JProperty("commands", commands),
                new JProperty("debugContext", debug)
                );

            return Ok(jsonObject);
        }


        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("registration")]
        public IActionResult RegistrationHook([FromBody]RegistrationCallbackRequest request)
        {

            ////put any additional processing here, keep latency to a minimum


            //option 2 on the fly with JSON
            JObject value1 = new JObject(
                new JProperty("frequentFlyerNo", "123456789")
                );

            JObject command1 = new JObject(
                new JProperty("type", "com.okta.user.profile.update"),
                new JProperty("value", value1)
                );


            JArray commands = new JArray();
            commands.Add(command1);


            JObject debug = new JObject(
               new JProperty("executionTimeMillis", 200)
               );


            JObject jsonObject = new JObject(
                new JProperty("commands", commands),
                new JProperty("debugContext", debug)
                );

            return Ok(jsonObject);
        }

        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("import")]
        public IActionResult ImportHook([FromBody]ImportCallbackRequest request)
        {
            ////option 1 use class to sructure output object
            //ImportCallbackResponse callbackResponse = new ImportCallbackResponse();

            ////put any additional processing here, keep latency to a minimum

            ////mock up sample response json
            //callbackResponse.commands = new List<Command>();
            //Command command1 = new Command();
            //command1.type = "com.okta.action.update";
            //command1.value = new ActionValue();
            //command1.value.result = "CREATE_USER";
            //callbackResponse.commands.Add(command1);

            //return callbackResponse;

            //option 2 on the fly with JSON
            JObject value1 = new JObject(
                new JProperty("result", "CREATE_USER")
                );

            JObject command1 = new JObject(
                new JProperty("type", "com.okta.action.update"),
                new JProperty("value", value1)
                );

            JObject value2 = new JObject(
                new JProperty("city", "St Louis")
                );
            JObject command2 = new JObject(
                new JProperty("type", "com.okta.user.profile.update"),
                new JProperty("value", value2)
                );

            JArray commands = new JArray();
            commands.Add(command1);
            commands.Add(command2);

            JObject debug = new JObject(
               new JProperty("executionTimeMillis", 200)
               );


            JObject jsonObject = new JObject(
                new JProperty("commands", commands),
                new JProperty("debugContext", debug)
                );

            return Ok(jsonObject);
            //return Json(jsonObject);
        }

        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("token")]
        public TokenCallbackResponse TokenHook([FromBody]TokenCallbackRequest request)
        {
            TokenCallbackResponse callbackResponse = new TokenCallbackResponse();
            string myParams = null;

            //extract extraParams from request
            string myUrl = request.data.context.request.url.value;
            int index1 = myUrl.IndexOf("&extra_param=");
            string partial = myUrl.Substring(index1 + 13);
            int index2 = partial.IndexOf("&");
            if (index2 > 0)
            {
                myParams = partial.Substring(0, index2);
            }
            else
            {
                myParams = partial;
            }


            // use passed in myParams to add user info to token
            // put any additional processing here, keep latency to a minimum


            //mock up sample response json
            callbackResponse.commands = new List<Command1>();

            Command1 command1 = new Command1();
            command1.type = "com.okta.identity.patch";
            command1.value = new List<Value>();
            Value value1 = new Value();
            value1.op = "add";
            value1.path = "/claims/AddValueFromHook";
            value1.value = "1313 Mockingbird Lane";
            command1.value.Add(value1);
            callbackResponse.commands.Add(command1);

            //Command1 command2 = new Command1();
            //command2.type = "com.okta.identity.patch";
            //command2.value = new List<Value>();
            //Value value2 = new Value();
            //value2.op = "replace";
            //value2.path = "/claims/guid";
            //value2.value = "TYTGVRVBJOOINONO";
            ////value2.value = myParams;
            //command2.value.Add(value2);

            //callbackResponse.commands.Add(command2);


            Command1 command3 = new Command1();
            command3.type = "com.okta.access.patch";
            command3.value = new List<Value>();
            Value value2 = new Value();
            value2.op = "add";
            value2.path = "/claims/AddFromHook";
            value2.value = "Toronto";
            //value2.value = myParams;
            command3.value.Add(value2);

            callbackResponse.commands.Add(command3);



            callbackResponse.debugContext = new Debugcontext();
            callbackResponse.debugContext.extraParams = "myDebugInfo";

            return callbackResponse;
        }

        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("clientCredToken")]
        public TokenCallbackResponse ClientCredTokenHook([FromBody] TokenCallbackRequest request)
        {
            TokenCallbackResponse callbackResponse = new TokenCallbackResponse();
            string myParams = null;

            //extract extraParams from request
            string myUrl = request.data.context.request.url.value;
            int index1 = myUrl.IndexOf("?extra_param=");
            string partial = myUrl.Substring(index1 + 13);
            int index2 = partial.IndexOf("&");
            if (index2 > 0)
            {
                myParams = partial.Substring(0, index2);
            }
            else
            {
                myParams = System.Web.HttpUtility.UrlDecode(partial);
            }


            // use passed in myParams to add user info to token
            // put any additional processing here, keep latency to a minimum


            //mock up sample response json
            callbackResponse.commands = new List<Command1>();


            Command1 command3 = new Command1();
            command3.type = "com.okta.access.patch";
            command3.value = new List<Value>();
            Value value2 = new Value();
            value2.op = "add";
            value2.path = "/claims/AddFromHook";
            value2.value = myParams;
            //value2.value = myParams;
            command3.value.Add(value2);

            callbackResponse.commands.Add(command3);

            callbackResponse.debugContext = new Debugcontext();
            callbackResponse.debugContext.extraParams = myParams;

            return callbackResponse;
        }

        [EnableCors("AllowAll")]
        [HttpPost]
        [Route("saml")]
        public SamlCallbackResponse SamlHook([FromBody] SamlCallbackRequest request)
        {
            SamlCallbackResponse callbackResponse = new SamlCallbackResponse();
            string myParams = null;

            //// put any additional processing here, keep latency to a minimum


            //mock up sample response json
            callbackResponse.commands = new List<Command5>();

            Command5 command5 = new Command5();
            command5.type = "com.okta.assertion.patch";
            command5.value = new List<Value5>();
            Value5 myValue = new Value5();
            myValue.op = "add";
            myValue.path = "/claims/AddValueFromHook";
            myValue.value = new Value51();
            myValue.value.attributes = new Attributes6();
            myValue.value.attributes.NameFormat = "urn:oasis:names:tc:SAML:2.0:attrname-format:basic";
            myValue.value.attributeValues = new List<Attributevalue6>();
            Attributevalue6 attributeValue6 = new Attributevalue6();
            attributeValue6.attributes = new Attributes7();
            attributeValue6.attributes.xsitype = "xs:string";
            attributeValue6.value = "SomeExternalData";
            myValue.value.attributeValues.Add(attributeValue6);
            command5.value.Add(myValue);
            callbackResponse.commands.Add(command5);

            //callbackResponse.debugContext = new Debugcontext();
            //callbackResponse.debugContext.extraParams = "myDebugInfo";

            return callbackResponse;
        }


        [EnableCors("AllowAll")]
        [HttpGet]
        [Route("GetString")]
        public IEnumerable<string> GetString()
        {
            return new string[] { "InlineHooks", "Demo" };
        }


    }
}