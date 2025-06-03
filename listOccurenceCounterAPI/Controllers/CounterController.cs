using Microsoft.AspNetCore.Mvc;
using listOccurrenceCounterAPI.Services;


namespace listOccurenceCounterAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CounterController : ControllerBase
    {
        [HttpPost("strings")]
        public IActionResult CountStrings([FromBody] List<string> input)
        {
            var result = Counter.CountOccurrences(input);
            return Ok(result);
        }

        [HttpPost("ints")]
        public IActionResult CountInts([FromBody] List<int> input)
        {
            var result = Counter.CountOccurrences(input);
            return Ok(result);
        }

        [HttpPost("chars")]
        public IActionResult CountChars([FromBody] List<char> input)
        {
            var result = Counter.CountOccurrences(input);
            return Ok(result);
        }
    }
}