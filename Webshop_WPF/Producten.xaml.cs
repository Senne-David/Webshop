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
    /// Interaction logic for Producten.xaml
    /// </summary>
    public partial class Producten : Window
    {
        private Controller _controller;
        public Producten()
        {
            InitializeComponent();
            _controller = new Controller();
            lbxProducten.Items.Refresh();
            lbxProducten.ItemsSource = _controller.getProduct();
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            Productentoevoegen addproductvenster = new Productentoevoegen();
            addproductvenster.Show();
            this.Close();
        }

        private void btnSluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
