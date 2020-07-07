using VisualBariga.Model;
using VisualBariga.View;
using VisualBariga.Warehouse;

namespace VisualBariga.Controller
{
    public class GoZaygolController
    {
        private readonly RatesWarehouse _ratesWarehouse;
        private readonly ZaYglom _goZaygol;
        private Currency _selectedCurrency;

        public GoZaygolController()
        {
            _ratesWarehouse = RatesWarehouse.getInstance();
            _goZaygol = new ZaYglom(_ratesWarehouse.GetRates());
            _goZaygol.NormClicked += GoZaygol_NormClicked;
        }

        public void Start(Currency selectedCurrency)
        {
            _selectedCurrency = selectedCurrency;
            _goZaygol.SetCurrency(_selectedCurrency);
            _goZaygol.Show();
        }

        private void GoZaygol_NormClicked(double updatedRate)
        {
            var rates = _ratesWarehouse.GetRates();
            if (_selectedCurrency == Currency.Usd)
            {
                rates.UsdRate = updatedRate;
            }
            else
            {
                rates.EuroRate = updatedRate;
            }

            var obminController = new ObminController();
            obminController.Start(_selectedCurrency);
            _goZaygol.Close();
        }
    }
}
