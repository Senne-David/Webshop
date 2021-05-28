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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Webshop_domain.Business;

namespace Webshop_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAanmelden_Click(object sender, RoutedEventArgs e)
        {
            Aanmelden aanmeldvenster = new Aanmelden();
            aanmeldvenster.Show();
            this.Close();
        }

        private void btnProducten_Click(object sender, RoutedEventArgs e)
        {
            Producten productenvenster = new Producten();
            productenvenster.Show();
        }
    }
}
