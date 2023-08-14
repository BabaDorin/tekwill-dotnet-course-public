public interface IWeatherService
{
    decimal GetTemperature(string city);
}

public class WeatherAnalyzer
{
    private IWeatherService _weatherService;

    public WeatherAnalyzer(IWeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public string AnalyzeWeather(string city)
    {
        var temperature = _weatherService.GetTemperature(city);

        if (temperature < 10)
        {
            return "Cold";
        }
        else if (temperature < 30)
        {
            return "Moderate";
        }
        else
        {
            return "Hot";
        }
    }
}

class Program
{
    static void Main()
    {

    }
}