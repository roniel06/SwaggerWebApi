using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SwggerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        /// <summary>
        /// This Method Returns the age
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        [HttpGet("GetMyAge")]
        public IActionResult GetMyAge(int age)
        {
            return Ok(age);
        }
    }
}
