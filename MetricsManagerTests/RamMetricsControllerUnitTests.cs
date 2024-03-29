﻿namespace MetricsManagerTests;
public class RamMetricsControllerUnitTests
{
    private RamMetricsController controller;

    public RamMetricsControllerUnitTests()
    {
        controller = new RamMetricsController();
    }

    [Fact]
    public void GetMetricsFromAgent_ReturnsOk()
    {
        //Arrange
        var agentId = 1;
        var fromTime = TimeSpan.FromSeconds(0);
        var toTime = TimeSpan.FromSeconds(100);

        //Act
        var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);

        // Assert
        _ = Assert.IsAssignableFrom<IActionResult>(result);
    }
}