using VisualBariga.Model;
using VisualBariga.Warehouse;

namespace VisualBariga.Controller
{
    internal class RootController
    {
        private MainScreen _mainScreen;
        private readonly RatesWarehouse _ratesWarehouse;

        public RootController()
        {
            _ratesWarehouse = RatesWarehouse.getInstance();
        }

        public void Start()
        {
            var ratesModel = new BarigaRates();
            _ratesWarehouse.SaveRates(ratesModel);

            _mainScreen = new MainScreen(ratesModel);
            _mainScreen.Show();
            MainScreenSubscribe();
        }

        private void MainScreenSubscribe()
        {
            _mainScreen.ButtonClicked += MainScreenButtonClickedHandler;
        }

        private void MainScreenUnsubscribe()
        {
            _mainScreen.ButtonClicked -= MainScreenButtonClickedHandler;
        }

        private void MainScreenButtonClickedHandler(bool result)
        {
            if (result)
            {
                _mainScreen_YesButtonClicked();
            }
            else
            {
                _mainScreen_NoButtonClicked();
            }
        }

        private void _mainScreen_NoButtonClicked()
        {
            MainScreenUnsubscribe();
            _mainScreen.Close();
        }
               
        private void _mainScreen_YesButtonClicked()
        {
            MainScreenUnsubscribe();
            var choiseController = new ChooseController();
            choiseController.Start();
            _mainScreen.Close();
        }
    }
}
