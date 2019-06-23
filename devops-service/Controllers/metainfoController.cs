using System;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace devops_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class metainfoController : ControllerBase
    {
        // GET
        [HttpGet]
        public ActionResult<string> Get()
        {
            var servicevalue = ConfigurationManager.AppSetting["ServiceInfo:Version"];
            var servicedescription = ConfigurationManager.AppSetting["ServiceInfo:Version"];
            var serviceframework = ConfigurationManager.AppSetting["ServiceInfo:Framework"];
            var servicedeployment = ConfigurationManager.AppSetting["ServiceInfo:DeploymentMethod"];
            var outputstring = @"Service Name : Devops Service {0} 
            Version : {1} {0} 
            Description : {2} {0} 
            Framework : {3} {0} 
            Deployment Method : {4} ";
            string serviceinfo = string.Format(outputstring,Environment.NewLine,servicevalue,servicedescription,serviceframework,servicedeployment);
            return Ok(serviceinfo);
        }

          
    }
}
