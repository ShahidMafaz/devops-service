using System;
using Microsoft.AspNetCore.Mvc;

namespace devops_service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class healthzController : ControllerBase
    {
        // GET api/myob
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("HEALTHY");
        }

       
    }
}
