[Route("api/metrics/hdd")]
[ApiController]
public class HddMetricsController : Controller
{
    [HttpGet("left/from/{fromTime}/to/{toTime}")]
    public IActionResult GetMetricsFromAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
    {
        return Ok();
    }
}
