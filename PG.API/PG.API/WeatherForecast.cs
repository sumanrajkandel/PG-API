
namespace PG.API;
public class WeatherForecast
{
    // comment added for test...
    public DateTime Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string? Summary { get; set; }

    public int TestProp { get; set; }
}
