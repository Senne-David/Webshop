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
    /// Interaction logic for getWinkelwagen.xaml
    /// </summary>
    public partial class getWinkelwagen : Window
    {
        private Controller _controller;
        public getWinkelwagen()
        {
            InitializeComponent();
            _controller = new Controller();
            lbxWinkelwagen.Items.Refresh();
            lbxWinkelwagen.ItemsSource = _controller.getWinkelwagen();
            lbxAantallen.Items.Refresh();
            lbxAantallen.ItemsSource = _controller.getWinkelwagenHasProducten();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void lbxWinkelwagen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
