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
    
    public partial class A3 : Window
    {
        scheduleTableAdapter schedule = new scheduleTableAdapter();
        stylistsTableAdapter stylists = new stylistsTableAdapter();
        
        public A3()
        {
            InitializeComponent();
            GRAPHIK.ItemsSource = schedule.GetData();
            Combo.ItemsSource = stylists.GetData();
            Combo.DisplayMemberPath = "last_name";
            Combo.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            schedule.InsertQuery(T1.Text, T2.Text, T3.Text, Convert.ToInt32(Combo.SelectedValue));
            GRAPHIK.ItemsSource = schedule.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (GRAPHIK.SelectedItem as DataRowView).Row[0];
            schedule.DeleteQuery(Convert.ToInt32(id));
            GRAPHIK.ItemsSource = schedule.GetData();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (GRAPHIK.SelectedItem as DataRowView).Row[0];
            schedule.UpdateQuery(T1.Text, T2.Text,T3.Text, Convert.ToInt32(Combo.SelectedValue), Convert.ToInt32(id));
            GRAPHIK.ItemsSource = schedule.GetData();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Role1 wim = new Role1();
            wim.Show();
        }
    }
}
