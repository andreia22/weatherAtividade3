﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wheather.Models
{
    public class Forecast
    {
        public string City { get; set; }
        public List<ForecastItem> Items { get; set; }

    }
}
