using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FileUploadApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FileUploadApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
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

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost("[action]")]
        public ActionResult Save([FromForm]Student student)
        {
            //Do Debugger befour this line, you can see fule instance on student variable
            student.Logo = null;
            return Ok(new { uploadStatus = "Success" ,  student });
        }

        [HttpPost("[action]")]
        public ActionResult SaveWithoutFile(Student student)
        {
            return Ok(student);
        }
    }
}
