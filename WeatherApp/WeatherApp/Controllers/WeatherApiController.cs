using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeatherApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WeatherApp.Controllers
{
    public class WeatherApiController : Controller
    {
        public IActionResult WeatherByCity(City city)
        {
            ApiClient apiClient = new ApiClient();

            var weatherObj = apiClient.GetCity(city.Name);

            var x= weatherObj.Result.main.temp;

            return View(weatherObj.Result);
        }
    }
}
