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
    /// Interaction logic for AddProducten.xaml
    /// </summary>
    public partial class AddProducten : Window
    {
        private Controller _controller;
        public AddProducten()
        {
            InitializeComponent();
            _controller = new Controller();
        }

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Winkelwagen_has_Producten aantal = new Winkelwagen_has_Producten(Convert.ToInt32(tbxAantal.Text), Convert.ToInt32(tbxProductID.Text), Convert.ToInt32(tbxWinkelwagenID.Text));
            _controller.addWinkelwagenHasProducten(aantal);
        }
    }
}
