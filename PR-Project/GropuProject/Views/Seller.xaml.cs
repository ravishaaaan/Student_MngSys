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

namespace GropuProject.Views
{
    /// <summary>
    /// Interaction logic for Seller.xaml
    /// </summary>
    public partial class Seller : Window
    {
        public Seller()
        {
            InitializeComponent();
        }

        private void Button_click2(object sender, RoutedEventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Password;

            if (username == "student" && password == "password")
            {
                MessageBox.Show("Login successful!");
                var win1 = new AdminSub();
                win1.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var win2 = new Admin();
            win2.Show();
            this.Close();
        }
    }
}
