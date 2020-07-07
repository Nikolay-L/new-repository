using VisualBariga.View;

namespace VisualBariga.Controller
{
    public class ChooseController
    {
        private readonly ChooseScreen _makeChoice;

        public ChooseController()
        {
            _makeChoice = new ChooseScreen();
            _makeChoice.CurrencySelected += CurencySelectedHandler;
        }

        public void Start()
        {
            _makeChoice.Show();
        }

        private void CurencySelectedHandler()
        {
            _makeChoice.CurrencySelected -= CurencySelectedHandler;

            var goZaygolController = new GoZaygolController();
            goZaygolController.Start(_makeChoice.CurrencyThatUserChoose);
            _makeChoice.Close();
        }
    }
}
