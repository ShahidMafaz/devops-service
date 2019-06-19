using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace devops_service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class metainfoController : ControllerBase
    {
        // GET
        [HttpGet]
        public ActionResult<string> Get()
        {
            var servicevalue = ConfigurationManager.AppSetting["ServiceInfo:Version"];
            var outputstring = @"Service Name : Devops Service {0} 
            Version : {1} {0} 
            Commit HASH : test";
            string serviceinfo = string.Format(outputstring,Environment.NewLine,servicevalue);
            return Ok(serviceinfo);
        }

          
    }
}
