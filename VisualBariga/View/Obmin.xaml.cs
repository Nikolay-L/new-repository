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

namespace VisualBariga.View
{
    /// <summary>
    /// Interaction logic for Obmin.xaml
    /// </summary>
    public partial class Obmin : Window
    {
        public event Action ConvertClicked = delegate { };
        private BarigaRates barigaRates;
        public Obmin(BarigaRates rates)
        {
            barigaRates = rates;
            InitializeComponent();
            Convert.Click += Convert_Click;
        }

        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            ConvertToUsd();
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

