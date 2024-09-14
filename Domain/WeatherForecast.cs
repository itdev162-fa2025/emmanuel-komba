namespace Domain;

public  class WeatherForecast
{
    public int Id { get; set; }

    public DateOnly Date { get; set; }

    public int temperatureC { get; set; }

    public int temperatureF => 32 + (int)(temperatureC / 0.5556);

    public string? Summary { get; set; }
}