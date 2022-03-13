﻿namespace MetricsManagerTests;
public class CpuMetricsControllerUnitTests
{
    private CpuMetricsController controller;

    public CpuMetricsControllerUnitTests()
    {
        controller = new CpuMetricsController();
    }

    [Fact]
    public void GetMetricsFromAgent_ReturnsOk()
    {
        //Arrange
        var fromTime = TimeSpan.FromSeconds(0);
        var toTime = TimeSpan.FromSeconds(100);

        //Act
        var result = controller.GetMetricsFromAgent(fromTime, toTime);

        // Assert
        _ = Assert.IsAssignableFrom<IActionResult>(result);
    }
}