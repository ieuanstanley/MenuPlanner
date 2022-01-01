using Microsoft.AspNetCore.Mvc;

namespace MenuPlanner.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MenuPlannerController : ControllerBase
    {
        private readonly ILogger<MenuPlannerController> _logger;

        public MenuPlannerController(ILogger<MenuPlannerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public bool Get()
        {
            return true;
        }
    }
}