[Route("api/metrics/dotnet")]
[ApiController]
public class DotNetMetricsController : Controller
{
    [HttpGet("error-count/from/{fromTime}/to/{toTime}")]
    public IActionResult GetMetricsFromAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
    {
        return Ok();
    }
}
