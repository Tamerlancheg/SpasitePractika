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
using SpasitePractika.msdbDataSetTableAdapters;

namespace SpasitePractika
{
    /// <summary>
    /// Логика взаимодействия для Role2.xaml
    /// </summary>
    public partial class Role2 : Window
    {
        public Role2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            U1 wim = new U1();
            wim.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            U2 wim = new U2();
            wim.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            U3 wim = new U3();
            wim.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            U4 wim = new U4();
            wim.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            U5 wim = new U5();
            wim.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainWindow wim = new MainWindow();
            wim.Show();
        }
    }
}
