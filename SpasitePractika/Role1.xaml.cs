using SpasitePractika.msdbDataSetTableAdapters;
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
using System.Data;

namespace SpasitePractika
{   
    public partial class Role1 : Window
    {
        LoginDataTableAdapter LoginData = new LoginDataTableAdapter();
        public Role1()
        {
            InitializeComponent();
            
        }

        private void BDOBAV_Click(object sender, RoutedEventArgs e)
        {
            NewRole wim = new NewRole();
            wim.Show();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            A1 wim = new A1();
            wim.Show();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            A2 wim = new A2();
            wim.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            A3 wim = new A3();
            wim.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            A4 wim = new A4();
            wim.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindow wim = new MainWindow();
            wim.Show();
        }
    }
}
