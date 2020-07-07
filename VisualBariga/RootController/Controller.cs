using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VisualBariga.Model;
using VisualBariga.View;

namespace VisualBariga.RootController
{
    class Controller

    {
        private MainScreen _mainScreen;
        private ChooseScreen makeChoice;
        private ZaYglom goZaygol;
        private BarigaRates rates;

        public void Start()
        {
             rates = new BarigaRates();

            _mainScreen = new MainScreen(rates);
            _mainScreen.Show();
            _mainScreen.YesButtonClicked += _mainScreen_YesButtonClicked;
            _mainScreen.NoButtonClicked += _mainScreen_NoButtonClicked;
        }

        private void _mainScreen_NoButtonClicked()
        {
            _mainScreen.NoButtonClicked -= _mainScreen_NoButtonClicked;
            _mainScreen.Close();
        }

        private void _mainScreen_YesButtonClicked()
        {
            _mainScreen.YesButtonClicked -= _mainScreen_YesButtonClicked;
            makeChoice = new ChooseScreen();
            _mainScreen.Close();
            makeChoice.Show();
            makeChoice.UsdButtonClicked += MakeChoice_UsdButtonClicked;
            makeChoice.EuroButtonClicked += MakeChoice_EuroButtonClicked;
        }

        private void MakeChoice_EuroButtonClicked()
        {
            makeChoice.EuroButtonClicked -= MakeChoice_EuroButtonClicked;
            MakeChoice_UsdButtonClicked();
        }

        private void MakeChoice_UsdButtonClicked()
        {
            makeChoice.UsdButtonClicked -= MakeChoice_UsdButtonClicked;
            goZaygol = new ZaYglom(rates);
            makeChoice.Close();
            goZaygol.Show();
            goZaygol.NormClicked += GoZaygol_NormClicked;
        }

        private void GoZaygol_NormClicked()
        {
            var obminDeneg = new Obmin(rates);
            goZaygol.Close();
            obminDeneg.Show();
        }
    }
}
