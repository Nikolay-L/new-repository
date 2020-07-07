using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualBariga.Model;

namespace VisualBariga.Warehouse
{
    public class RatesWarehouse
    {
        private static RatesWarehouse instance;

        private RatesWarehouse()
        { }

        public static RatesWarehouse getInstance()
        {
            if (instance == null)
            {
                instance = new RatesWarehouse();
            }
            return instance;
        }

        private BarigaRates _rates;

        public void SaveRates(BarigaRates rates)
        {
            _rates = rates;
        }

        public BarigaRates GetRates()
        {
            if (_rates == null)
            {
                return BarigaRates.Empty;
            }
            return _rates;
        }
    }
}
