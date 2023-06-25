using System;
using System.Collections.Generic;
using System.Text;

namespace Wheather.Models
{
    internal class ForecastGroup : List<ForecastItem>
    {
        public ForecastGroup() {


        }
        public ForecastGroup(IEnumerable<ForecastItem> items)
        {
            AddRange(items);
        }
        public DateTime Date { get; set; }
        public string DateAsString => Date.ToShortDateString();
        public List<ForecastItem> Items => this;
    }



}
