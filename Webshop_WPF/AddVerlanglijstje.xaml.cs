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
    /// Interaction logic for AddVerlanglijstje.xaml
    /// </summary>
    public partial class AddVerlanglijstje : Window
    {
        private Controller _controller;
        public AddVerlanglijstje()
        {
            InitializeComponent();
            _controller = new Controller();
            lbxVerlanglijsten.Items.Refresh();
            lbxVerlanglijsten.ItemsSource = _controller.getVerlanglijstje();
        }

        private void btnTerug_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAanmaken_Click(object sender, RoutedEventArgs e)
        {
            Verlanglijst verlanglijstje = new Verlanglijst(Convert.ToInt32(tbxProductID.Text), Convert.ToInt32(tbxWinkelwagenID.Text));
            _controller.addVerlanglijstje(verlanglijstje);
        }
    }
}
