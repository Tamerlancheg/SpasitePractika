using System;
using System.Collections.Generic;
using System.Data;
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
using SpasitePractika.modelDataSetTableAdapters;

namespace SpasitePractika
{
    public partial class U5 : Window
    {
        salon_infoTableAdapter salon_Info = new salon_infoTableAdapter();
        public U5()
        {
            InitializeComponent();
            INFO.ItemsSource =  salon_Info.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            salon_Info.InsertQuery(T1.Text, T2.Text, T3.Text);
            INFO.ItemsSource = salon_Info.GetData();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (INFO.SelectedItem as DataRowView).Row[0];
            salon_Info.DeleteQuery(Convert.ToInt32(id));
            INFO.ItemsSource = salon_Info.GetData();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (INFO.SelectedItem as DataRowView).Row[0];
            salon_Info.UpdateQuery(T1.Text, T2.Text,T3.Text,Convert.ToInt32(id));
            INFO.ItemsSource = salon_Info.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Role2 wim = new Role2();
            wim.Show();
        }
    }
}
