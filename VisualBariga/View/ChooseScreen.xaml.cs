using System;
using System.Windows;
using VisualBariga.Model;

namespace VisualBariga.View
{
    /// <summary>
    /// Interaction logic for ChooseScreen.xaml
    /// </summary>
    public partial class ChooseScreen : Window
    {
        //public event Action<Currency> CurrencySelected = delegate { };
        public event Action CurrencySelected = delegate { };
        public Currency CurrencyThatUserChoose { get; private set; }

        public ChooseScreen()
        {
            InitializeComponent();
            PickedUSD.Click += PickedUSD_Click;
            PickedEuro.Click += PickedEuro_Click;
        }

        private void PickedEuro_Click(object sender, RoutedEventArgs e)
        {
            //CurrencySelected(Currency.Euro);
            CurrencyThatUserChoose = Currency.Euro;
            CurrencySelected();
        }

        private void PickedUSD_Click(object sender, RoutedEventArgs e)
        {
            //CurrencySelected(Currency.Usd);
            CurrencyThatUserChoose = Currency.Usd;
            CurrencySelected();
        }
    }
}
