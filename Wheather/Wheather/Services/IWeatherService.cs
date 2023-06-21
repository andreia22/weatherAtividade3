using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Wheather.Models;

namespace Wheather.Services
{
    internal interface IWeatherService
    {
        Task<Forecast> GetForecast(double latitude, double longitude);

    }
}
