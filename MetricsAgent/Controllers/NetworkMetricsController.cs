[Route("api/metrics/network")]
[ApiController]
public class NetworkMetricsController : Controller
{
    [HttpGet("network/from/{fromTime}/to/{toTime}")]
    public IActionResult GetMetricsFromAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
    {
        return Ok();
    }
}
