using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalX
{
    class connectDatabase
    {
        App currentApp;
        public void DatabaseSetUp()
        {
            currentApp = (App)Application.Current;
            // currentApp.currentUser = null;

            if (/*currentApp.UserPermissions != null*/true)
            {
                //currentApp.UserPermissions.Clear();
                //currentApp.UserPermissions = null;
            }
        }

        public void loginButton(string UserName, string Password)
        {

            /*
            Employee currentEmployee =
            (
                    from curEmp
                    in currentApp.dbContext.Employees
                    where (curEmp.UserName == UserName.ToString) && (curEmp.Password == Password.ToString)
                    select curEmp).FirstOrDefault();
            */

            if((UserName.ToString() != null) && (Password.ToString() != null))
            {
                if (/*currentEmployee != null*/ true)
                {
                    //currentApp.currentUser = currentEmployee;
                    //this.dialogResult = true;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Username or Password not entered", "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }


    }
}
