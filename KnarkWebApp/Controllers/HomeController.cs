using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace KnarkWebApp.Controllers {
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase {
        [HttpGet("ver")]
        public string Get()
        {
            return "KnarkWebApp";
        }
    }
}
