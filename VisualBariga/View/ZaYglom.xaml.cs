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
    /// Interaction logic for ZaYglom.xaml
    /// </summary>
    public partial class ZaYglom : Window
    {
        public event Action NormClicked = delegate { };
        private BarigaRates barigaRates;
        public ZaYglom(BarigaRates rates)
        {
            InitializeComponent();
            Norm.Click += Norm_Click;
            barigaRates = rates;
        }

        private void Norm_Click(object sender, RoutedEventArgs e)
        {
            Norm.Click -= Norm_Click;
            var EnteredKurs = SetKurs.Text;
            double updatedKurs;
            var myKurs = double.TryParse(EnteredKurs, out updatedKurs);
            barigaRates.UsdRate = updatedKurs;
            NormClicked();
        }
    }
}