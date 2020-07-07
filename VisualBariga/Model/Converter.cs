using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualBariga.Model
{
    class Converter
    {
        public double UatoUsd(double kurs, double UaValue)
        {
            var result = UaValue / kurs;
            return result;
        }
    }
}
