[Route("api/metrics/ram")]
[ApiController]
public class RamMetricsController : Controller
{
    [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}")]
    public IActionResult GetMetricsFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
    {
        return Ok();
    }

    [HttpGet("agent/{agentId}/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
    public IActionResult GetMetricsPercentileFromAgent([FromRoute] int agentId, [FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] int percentile)
    {
        return Ok();
    }

    [HttpGet("cluster/from/{fromTime}/to/{toTime}")]
    public IActionResult GetMetricsFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
    {
        return Ok();
    }

    [HttpGet("cluster/from/{fromTime}/to/{toTime}/percentiles/{percentile}")]
    public IActionResult GetMetricsPercentileFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] int percentile)
    {
        return Ok();
    }
}
