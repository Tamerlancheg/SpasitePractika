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
    public partial class A2 : Window
    {
        stylist_availabilityTableAdapter stylist_availability = new stylist_availabilityTableAdapter();
        stylistsTableAdapter stylists = new stylistsTableAdapter(); 
        public A2()
        {
            InitializeComponent();
            ZASTYL.ItemsSource = stylist_availability.GetData();
            Combo.ItemsSource = stylists.GetData();
            Combo.DisplayMemberPath = "last_name";
            Combo.SelectedValuePath = "id";
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            stylist_availability.InsertQuery(T1.Text, T2.Text, Convert.ToInt32(Combo.SelectedValue));
            ZASTYL.ItemsSource = stylist_availability.GetData();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            object id = (ZASTYL.SelectedItem as DataRowView).Row[0];
            stylist_availability.DeleteQuery(Convert.ToInt32(id));
            ZASTYL.ItemsSource = stylist_availability.GetData();
        }

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            object id = (ZASTYL.SelectedItem as DataRowView).Row[0];
            stylist_availability.UpdateQuery(T1.Text, T2.Text, Convert.ToInt32(Combo.SelectedValue), Convert.ToInt32(id));
            ZASTYL.ItemsSource = stylist_availability.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Role1 wim = new Role1();
            wim.Show();
        }
    }
}
