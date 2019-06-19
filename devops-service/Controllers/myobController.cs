using System;
using Microsoft.AspNetCore.Mvc;

namespace devops_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class myobController : ControllerBase
    {
        // GET api/myob
        [HttpGet]
        public ActionResult<string> Get()
        {
            return Ok("Hello MYOB");
        }

        // GET api/myob/test
        [HttpGet("{inputtext}")]
        public ActionResult<string> Get(string inputtext)
        {
            return Ok("Hello " + inputtext);
        }

        
    }
}
