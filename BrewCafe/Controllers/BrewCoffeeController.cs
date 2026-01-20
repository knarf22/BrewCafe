using BrewCafe.Models;
using BrewCafe.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace BrewCafe.Controllers
{
    [ApiController]
    [Route("brew-coffee")]
    public class BrewCoffeeController : ControllerBase
    {
        private readonly ICoffeeCounter _coffeeCounter;
        private readonly IDateTimeProvider _dateTimeProvider;

        public BrewCoffeeController(
            ICoffeeCounter coffeeCounter,
            IDateTimeProvider dateTimeProvider)
        {
            _coffeeCounter = coffeeCounter;
            _dateTimeProvider = dateTimeProvider;
        }

        [HttpGet]
        public IActionResult BrewCoffee()
        {
            var now = _dateTimeProvider.Now;

            // Requirement #3 – April 1st
            if (now.Month == 4 && now.Day == 1)
            {
                return StatusCode(418);
            }

            // Requirement #2 – Out of coffee
            if (_coffeeCounter.IsOutOfCoffee())
            {
                return StatusCode(503);
            }

            var response = new BrewCoffeeResponse
            {
                Message = "Your piping hot coffee is ready",
                Prepared = now.ToString("yyyy-MM-ddTHH:mm:sszzz", CultureInfo.InvariantCulture)
            };

            return Ok(response);
        }
    }
}
