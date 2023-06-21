using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wheather.Models;

namespace Wheather.Services
{
    
        public class OpenWeatherMapWeatherService : IWeatherService
        {
            public async Task<Forecast> GetForecast(double latitude,
            double longitude)
            {
            }
        }

    
}
