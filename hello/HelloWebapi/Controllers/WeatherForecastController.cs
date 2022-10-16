using Microsoft.AspNetCore.Mvc;

namespace HelloWebapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }

    // [HttpGet]
    // //api/WeatherForecasts?id=3
    // public IEnumerable<WeatherForecast> GetById([FromQuery] string id)
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateTime.Now.AddDays(index),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }

    // [HttpGet("{id}")]
    // //api/WeatherForecasts/3
    // public IEnumerable<WeatherForecast> GetForecast(string id)
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateTime.Now.AddDays(index),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }

    // [HttpGet]
    // public IActionResult GetBook([FromQuery] string id)
    // {
    //     ... Komut satırları
    // }

    // [HttpGet("{id}")]
    // public IActionResult GetBook(string id)
    // {
    //     ... Komut satırları
    // }

    // [HttpPost]
    // public IActionResult CreateBook([FromBody]Book newBook)
    // {
    //     if(newBook==null)
    //         return BadRequest();

    //     _context.Books.Add(newBook);
    //     _context.SaveChanges();
    //     return Ok();
    // }
}
