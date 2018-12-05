﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherApp.Models
{
    public class WeatherApiModel
    {       
            public Coord coord { get; set; }
            public List<Weather> weather { get; set; }
            public string @base { get; set; }
            public Main main { get; set; }
            public float visibility { get; set; }
            public Wind wind { get; set; }
            public Clouds clouds { get; set; }
            public float dt { get; set; }
            public Sys sys { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public float cod { get; set; }     

            public DateTime UnixTimeStampToDateTime( double unixTimeStamp )
            {
                // Unix timestamp is seconds past epoch
                System.DateTime dtDateTime = new DateTime(1970,1,1,0,0,0,0,System.DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds( unixTimeStamp ).ToLocalTime();
                return dtDateTime;
            }
    }
}
