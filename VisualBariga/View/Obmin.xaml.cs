using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VisualBariga.Model;
using VisualBariga.Warehouse;

namespace VisualBariga.View
{
    /// <summary>
    /// Interaction logic for Obmin.xaml
    /// </summary>
    public partial class Obmin : Window
    {
        public event Action<string> ConvertClicked = delegate { };

        private BarigaRates barigaRates;

        public Obmin(BarigaRates rates, Currency selectedCurrency)
        {
            barigaRates = rates;
            InitializeComponent();
            Convert.Click += Convert_Click;
            TittleName.Text = $"BLIN NU LADNO, DAM TOBI {selectedCurrency}";
            ResultTittle.Text = $"Resultat, {selectedCurrency}";
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            ConvertClicked(GrnNaObmin.Text);
        }

        public void ShowResult(string result)
        {
            Result.Text = result;
        }

        private void ConvertToUsd()
        {
            var GrnText = GrnNaObmin.Text;
            double GrnSum;
            var isCanExchange = double.TryParse(GrnText, out GrnSum);
            if (!isCanExchange || GrnSum < 100)
            {
                Result.Text = "PNX";
            }
            else
            {
                var result = GrnSum / barigaRates.UsdRate;
                Result.Text = result.ToString();
            }
        }
    }
}

