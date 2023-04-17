using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatusChecker.models;
using System.Collections.Generic;

namespace StatusChecker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {


        [HttpGet]
        public IActionResult Show()
        {
            var appHealth = new
            {
                appStatus = "alive"
            };

            return Ok(appHealth);
        }

    }
}
