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

namespace MyWpfProject_NK
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

        private void btnIn_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == "Admin" || tbPassword.Text == "123")
            {
                MyWindows.AdminWindows adminWindows = new MyWindows.AdminWindows(); 
                adminWindows.Show();
                Close();
                return;
            }

            if (tbLogin.Text == "User" || tbPassword.Text == "123")
            {
                MyWindows.UserWindows userWindows = new MyWindows.UserWindows();
                userWindows.Show();
                Close();
                return;
            }

            MessageBox.Show("Error");
        }
    }
}
