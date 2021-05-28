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
    /// Interaction logic for Productentoevoegen.xaml
    /// </summary>
    public partial class Productentoevoegen : Window
    {
        private Controller _controller;
        public Productentoevoegen()
        {
            InitializeComponent();
            _controller = new Controller();
        }
        private void ClearInput()
        {
            tbxNaam.Clear();
            tbxCategorie.Clear();
            tbxCategorie.Clear();
            tbxPrijs.Clear();
        }
        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product(tbxNaam.Text, tbxCategorie.Text, tbxOmschrijving.Text, Convert.ToDouble(tbxPrijs.Text));
            _controller.addProduct(product);
            ClearInput();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Producten productvenster = new Producten();
            productvenster.Show();
            this.Close();
        }

        private void btnWinkelwagen_Click(object sender, RoutedEventArgs e)
        {
            getWinkelwagen getwinkelwagenvenster = new getWinkelwagen();
            getwinkelwagenvenster.Show();
        }
    }
}
