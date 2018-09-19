using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

/*
    * http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID={APIKEY}
    *  APIKEY = 9a5a6f66668c6b8861c56d58d5b5d4e3
    * */

namespace WeatherApp.Controllers
{
    public class WeatherApiController : Controller
    {
        // GET: /<controller>/
        public IActionResult Weather()
        {
                        

            return View();
        }
    }
}
