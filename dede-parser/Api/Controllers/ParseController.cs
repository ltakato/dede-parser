using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParserController : ControllerBase
    {
        private readonly ILogger<ParserController> _logger;

        public ParserController(ILogger<ParserController> logger)
        {
            _logger = logger;
        }

    }
}
