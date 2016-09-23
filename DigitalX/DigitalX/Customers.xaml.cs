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
    /// Interaction logic for Customers.xaml
    /// </summary>
    public partial class Customers : Page
    {
        public Customers()
        {
            InitializeComponent();
            /*
                dgdCustomer.ItemsSource = (from customerVariable in dbCustomers
                                           select new
                                           {
                                               customerVariable.CustomerID,
                                               customerVariable.FirstName,
                                               customerVariable.LastName,
                                               customerVariable.UserName
                                           }
                                          );
            */
        }
        public void backfunction()
        {
            NavigationWindow nw = (NavigationWindow)Window.GetWindow(this);
            nw.Close();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            backfunction();
        }
    }
}
