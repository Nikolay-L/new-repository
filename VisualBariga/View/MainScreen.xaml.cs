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

namespace VisualBariga
{
    /// <summary>
    /// Interaction logic for MainScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {
        public event Action<bool> ButtonClicked = delegate { };

        public MainScreen(BarigaRates rates)
        {
            InitializeComponent();
            UsdKurs.Text = rates.UsdRate.ToString();
            EuroKurs.Text = rates.EuroRate.ToString();
            Yes.Click += Yes_Click;
            No.Click += No_Click;
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            No.Click -= No_Click;
            ButtonClicked(false);
        }

        private void Yes_Click(object sender, RoutedEventArgs e)
        {
            Yes.Click -= Yes_Click;
            ButtonClicked(true);
        }
    }
}
