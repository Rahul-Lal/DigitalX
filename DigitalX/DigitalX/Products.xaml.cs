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
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : Page
    {
        public Products()
        {
            InitializeComponent();
            var db = new newDigitalXDBEntities();
            int numlock = 1;

            if(numlock == 0)
            {
                dgdProducts.ItemsSource = (from productVariable in db.Products
                                         select new
                                         {
                                             productVariable.ProductID,
                                             productVariable.RetailerID,
                                             productVariable.SubCategoryID,
                                             productVariable.ProductName,
                                             productVariable.ProductDescription,
                                             productVariable.Price,
                                             productVariable.UnitsInStock,
                                             productVariable.IsDiscontinued
                                         }
                                          );
            }
            else
            {
                this.Visibility = Visibility.Visible;
            }
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
