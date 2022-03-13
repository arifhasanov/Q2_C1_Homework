[Route("api/metrics/ram")]
[ApiController]
public class RamMetricsController : Controller
{
    [HttpGet("ram/available/from/{fromTime}/to/{toTime}")]
    public IActionResult GetMetricsFromAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
    {
        return Ok();
    }
}