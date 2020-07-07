using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBariga.Model
{
    public class BarigaRates
    {
        public static readonly BarigaRates Empty = new BarigaRates() { UsdRate = 0, EuroRate = 0 };

        public double UsdRate { get; set; } = 26.7 ;
        public double EuroRate { get; set; } = 30.4;
    }
}
