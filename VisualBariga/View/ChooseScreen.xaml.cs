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

namespace VisualBariga.View
{
    /// <summary>
    /// Interaction logic for ChooseScreen.xaml
    /// </summary>
    public partial class ChooseScreen : Window
    {
        public event Action UsdButtonClicked = delegate { };
        public event Action EuroButtonClicked = delegate { };
        public ChooseScreen()
        {
            InitializeComponent();
            PickedUSD.Click += PickedUSD_Click;
            PickedEuro.Click += PickedEuro_Click;
        }

        private void PickedEuro_Click(object sender, RoutedEventArgs e)
        {
            EuroButtonClicked();
        }

        private void PickedUSD_Click(object sender, RoutedEventArgs e)
        {
            UsdButtonClicked();
        }
    }
}
