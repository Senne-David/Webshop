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
using Webshop_domain.Business;

namespace Webshop_WPF
{
    /// <summary>
    /// Interaction logic for Klanten.xaml
    /// </summary>
    public partial class Klanten : Window
    {
        private Controller _controller;
        public Klanten()
        {
            InitializeComponent();
            _controller = new Controller();
            lbxKlanten.Items.Refresh();
            lbxKlanten.ItemsSource = _controller.getKlant();

        }

        private void btnSluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lbxKlanten_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
