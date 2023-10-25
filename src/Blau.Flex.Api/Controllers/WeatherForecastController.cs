using Blau.Flex.Data;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blau.Flex.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController(ApplicationDatabaseContext context) : ControllerBase
    {
        [HttpGet(Name = "Get"), Authorize]
        public bool Get()
        {
            var c = context.Tenants.FirstOrDefault();
            return true;
        }
    }
}
