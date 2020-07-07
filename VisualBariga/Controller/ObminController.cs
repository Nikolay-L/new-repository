using VisualBariga.Model;
using VisualBariga.View;
using VisualBariga.Warehouse;

namespace VisualBariga.Controller
{
    public class ObminController
    {
        private readonly RatesWarehouse _ratesWarehouse;
        private Obmin _obminDeneg;
        private Currency _currency;

        public ObminController()
        {
            _ratesWarehouse = RatesWarehouse.getInstance();
        }

        public void Start(Currency currency)
        {
            _currency = currency;
            _obminDeneg = new Obmin(_ratesWarehouse.GetRates(), currency);
            _obminDeneg.Show();
            _obminDeneg.ConvertClicked += OnConverClicked;
        }

        private void OnConverClicked(string inputedText)
        {
            double grnSum;
            var isCanExchange = double.TryParse(inputedText, out grnSum);
            if (!isCanExchange || grnSum < 100)
            {
                _obminDeneg.ShowResult("PNX");
            }
            else
            {
                var allRate = _ratesWarehouse.GetRates();
                var neededRate = _currency == Currency.Usd ? allRate.UsdRate : allRate.EuroRate;
                var result = grnSum / neededRate;
                _obminDeneg.ShowResult(result.ToString());
            }
        }
    }
}
