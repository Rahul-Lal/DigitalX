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

namespace DigitalX
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        NavigationWindow nw = new NavigationWindow();
        App app;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            nw.Title = "DigitalX | Orders";
            nw.Content = new Orders();
            nw.Show();
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            nw.Title = "DigitalX | Employees";
            nw.Content = new Employees();
            nw.Show();
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            nw.Title = "DigitalX | Customers";
            nw.Content = new Customers();
            nw.Show();
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            nw.Title = "DigitalX | Products";
            nw.Content = new Products();
            nw.Show();
        }

        private void btnLogOff_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            
            nw.Title = "DigitalX | Login";
            nw.Content = new MainWindow();
            nw.Show();
        }
    }
}
