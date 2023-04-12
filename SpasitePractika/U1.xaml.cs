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
using SpasitePractika.modelDataSetTableAdapters;
using System.Data;

namespace SpasitePractika
{
    public partial class U1 : Window
    {
        stylistsTableAdapter stylists = new stylistsTableAdapter();
        public U1()
        {
            InitializeComponent();
            STYL.ItemsSource = stylists.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            stylists.InsertQuery(T1.Text, T2.Text, T3.Text, T4.Text);
            STYL.ItemsSource = stylists.GetData();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (STYL.SelectedItem as DataRowView).Row[0];
            stylists.DeleteQuery(Convert.ToInt32(id));
            STYL.ItemsSource = stylists.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (STYL.SelectedItem as DataRowView).Row[0];
            stylists.UpdateQuery(T1.Text, T2.Text, T3.Text, T4.Text, Convert.ToInt32(id));
            STYL.ItemsSource = stylists.GetData();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Role2 wim = new Role2();
            wim.Show();
        }
    }
}
