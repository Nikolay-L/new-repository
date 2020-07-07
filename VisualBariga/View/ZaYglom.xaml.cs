using System;
using System.Windows;
using VisualBariga.Model;

namespace VisualBariga.View
{
    /// <summary>
    /// Interaction logic for ZaYglom.xaml
    /// </summary>
    public partial class ZaYglom : Window
    {
        public event Action<double> NormClicked = delegate { };

        private BarigaRates barigaRates;
        public ZaYglom(BarigaRates rates)
        {
            InitializeComponent();
            Norm.Click += Norm_Click;
            barigaRates = rates;
        }

        public void SetCurrency(Currency selectedCurrency)
        {
            CurrencyIndication.Text = $"Za 1 {selectedCurrency}";
        }

        private void Norm_Click(object sender, RoutedEventArgs e)
        {
            Norm.Click -= Norm_Click;
            var EnteredKurs = SetKurs.Text;
            double updatedKurs;
            var myKurs = double.TryParse(EnteredKurs, out updatedKurs);
            NormClicked(updatedKurs);
        }
    }
}