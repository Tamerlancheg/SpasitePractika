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
using static System.Net.Mime.MediaTypeNames;

namespace SpasitePractika
{
    public partial class U2 : Window
    {
        appointmentsTableAdapter appointments = new appointmentsTableAdapter();
        servicesTableAdapter services = new servicesTableAdapter();
        stylistsTableAdapter stylists = new stylistsTableAdapter();
        customersTableAdapter customers = new customersTableAdapter();
        public U2()
        {
            InitializeComponent();
            ZAPIS.ItemsSource = appointments.GetData();
            Combo1.ItemsSource = services.GetData();
            Combo1.DisplayMemberPath = "name";
            Combo1.SelectedValuePath = "id";
            Combo2.ItemsSource = stylists.GetData();
            Combo2.DisplayMemberPath = "last_name";
            Combo2.SelectedValuePath = "id";
            Combo3.ItemsSource = customers.GetData();
            Combo3.DisplayMemberPath = "last_name";
            Combo3.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            appointments.InsertQuery(T1.Text,Convert.ToInt32(Combo1.SelectedValue), Convert.ToInt32(Combo2.SelectedValue),Convert.ToInt32(Combo3.SelectedValue));
            ZAPIS.ItemsSource = appointments.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (ZAPIS.SelectedItem as DataRowView).Row[0];
            appointments.DeleteQuery(Convert.ToInt32(id));
            ZAPIS.ItemsSource = appointments.GetData();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (ZAPIS.SelectedItem as DataRowView).Row[0];
            appointments.UpdateQuery(T1.Text, Convert.ToInt32(Combo1.SelectedValue), Convert.ToInt32(Combo2.SelectedValue), Convert.ToInt32(Combo3.SelectedValue), Convert.ToInt32(id));
            ZAPIS.ItemsSource = appointments.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Role2 wim = new Role2();
            wim.Show();
        }
    }
}
