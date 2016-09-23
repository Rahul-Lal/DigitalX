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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
            connectDatabase cd = new connectDatabase();

        public Login()
        {
            InitializeComponent();
        }

        void backupLogin()
        {
            this.Visibility = Visibility.Collapsed;
            NavigationWindow nw = new NavigationWindow();
            
            nw.Title = "DigitalX | Main Menu";
            nw.Content = new MainPage();
            nw.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if ((txtUsername.Text != "") && (txtPassword.Password != ""))
            {
                cd.loginButton(txtUsername.Text, txtPassword.Password);
            }
            else
            {
                MessageBox.Show("Your are using backup login","WARNING", MessageBoxButton.OK, MessageBoxImage.Warning);
                backupLogin();
            }

            
        }
    }
}
