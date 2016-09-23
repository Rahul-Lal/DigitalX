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
        connectDatabase cd = new connectDatabase();

        public MainPage()
        {
            InitializeComponent();
        }
        public void backfunction()
        {
            nw = (NavigationWindow)Window.GetWindow(this);
            nw.Close();
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow nw = new NavigationWindow();
            nw.Title = "DigitalX | Orders";
            nw.Content = new Orders();
            nw.Show();
        }

        private void btnEmployees_Click(object sender, RoutedEventArgs e)
        {
            NavigationWindow nw = new NavigationWindow();
            nw.Title = "DigitalX | Employees";
            nw.Content = new Employees();
            nw.Show();
        }

        private void btnCustomers_Click(object sender, RoutedEventArgs e)
        {
            nw.Title = "DigitalX | Customers";
            nw.Content = new Customers();
            nw.Show();
        }

        private void btnProducts_Click(object sender, RoutedEventArgs e)
        {
            nw.Title = "DigitalX | Products";
            nw.Content = new Products();
            nw.Show();
        }

        private void btnLogOff_Click(object sender, RoutedEventArgs e)
        {
            bool loginApproved = false;
            this.Visibility = Visibility.Hidden;

            while(loginApproved != false)
            {
                Login Login = new Login();
                bool? retVal = Login.ShowDialog();

                if((retVal != false) && (retVal != null))
                {
                    loginApproved = true;
                    

                }
            }
            backfunction();
        }
    }
}
