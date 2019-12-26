using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using pavlovLab.Models;
using Serilog;

namespace pavlovLab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Content ("Поставьте зачет, пожалуйста");
        }
    }
}