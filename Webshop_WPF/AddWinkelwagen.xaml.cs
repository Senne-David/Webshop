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
    /// Interaction logic for AddWinkelwagen.xaml
    /// </summary>
    public partial class AddWinkelwagen : Window
    {
        private Controller _controller;
        public AddWinkelwagen()
        {
            InitializeComponent();
            _controller = new Controller();
        }
        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            Aanmelden aanmeldvenster = new Aanmelden();
            aanmeldvenster.Show();
            this.Close();
        }

        private void btnAanmaken_Click(object sender, RoutedEventArgs e)
        {
            Winkelwagen mandje = new Winkelwagen(tbxDatum.Text, Convert.ToDouble(tbxVerzendkosten.Text), tbxKaartnummer.Text, tbxVerzendmethode.Text, Convert.ToInt32(tbxKlantID.Text));
            _controller.addWinkelwagen(mandje);
        }

        private void btnAddproduct_Click(object sender, RoutedEventArgs e)
        {
            AddProducten addproductvenster = new AddProducten();
            addproductvenster.Show();
        }
    }
}
