using DependencyInjection.Examples.Host.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Examples.Host.Controllers
{
    [ApiController]
    [Route("v1/numbers")]
    public class NumberController : ControllerBase
    {
        private readonly INumberService _numberService;

        public NumberController(INumberService numberService)
        {
            _numberService = numberService;
        }

        [HttpGet]
        [Route("random")]
        [ProducesResponseType(typeof(int), 200)]
        public IActionResult GetRandomNumber()
        {
            int randomNumber = _numberService.GetRandomNumber();

            return Ok(randomNumber);
        }
    }
}
