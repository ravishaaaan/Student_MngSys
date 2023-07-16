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
    /// Interaction logic for SellerSub.xaml
    /// </summary>
    public partial class SellerSub : Window
    {
        public SellerSub()
        {
            DataContext = new SellerSubVM();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var win3 = new MainWindow();
            win3.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var win2 = new RegS();
            win2.Show();
            this.Close();
        }
    }
}
