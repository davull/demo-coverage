using Microsoft.AspNetCore.Mvc.Testing;

namespace WebApplication1.Tests.Controllers;

public class WeatherForecastControllerTests
{
    private readonly WebApplicationFactory<Program> _factory;

    public WeatherForecastControllerTests()
    {
        _factory = new WebApplicationFactory<Program>();
    }

    [Test]
    public async Task Get_ReturnsOk()
    {
        var client = _factory.CreateClient();

        var response = await client.GetAsync("/WeatherForecast");

        response.EnsureSuccessStatusCode();
    }
}