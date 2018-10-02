using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace WeatherApp.Models
{
    public class ApiClient
    {
        public async Task<WeatherApiModel> GetCity(string cityName)
        {
            using(var client = new HttpClient())
            {                
                    client.BaseAddress = new Uri("http://api.openweathermap.org");
                    var response = await client.GetAsync($"/data/2.5/weather?q={cityName}&appid=43212c8e45c6c7f65998bf7a5a51f03d");
                    response.EnsureSuccessStatusCode();

                    var stringResult =await response.Content.ReadAsStringAsync();
                    
                    var weather = JsonConvert.DeserializeObject<WeatherApiModel>(stringResult);
                    
                    return weather;              
            }
        }
        
    }
}
