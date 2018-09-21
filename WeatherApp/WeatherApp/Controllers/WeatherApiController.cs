using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using WeatherApp.Models;


namespace WeatherApp.Controllers
{
    public class WeatherApiController : Controller
    {        
        public IActionResult WeatherByCity(City city)
        {
            ApiClient apiClient = new ApiClient();

            var weatherObj = apiClient.GetCity(city.Name);

            return View(weatherObj);
        }
    }
}
