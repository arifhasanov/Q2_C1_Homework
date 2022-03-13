[Route("api/metrics/cpu")]
[ApiController]
public class CpuMetricsController : Controller
{
    [HttpGet("from/{fromTime}/to/{toTime}")]
    public IActionResult GetMetricsFromAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
    {
        return Ok();
    }
}