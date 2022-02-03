using System;
using Microsoft.AspNetCore.Mvc;

namespace OpenTelemetryBug.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExceptionThrowingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            throw new Exception();
        }
    }
}