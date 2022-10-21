using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializeJSON
{
    public class Weather
    {
        public DateTime Date { get; set; }
        public int TemperatureCelsius { get; set; }
        public string Summary { get; set; }
        public List<DateTime> DatesAvailable { get; set; }
        public TemperatureRanges TemperatureRanges { get; set; }
        public List<string> SummaryWords { get; set; }
    }
}
