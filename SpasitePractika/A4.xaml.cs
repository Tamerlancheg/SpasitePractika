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
    public partial class A4 : Window
    {
        paymentsTableAdapter payments = new paymentsTableAdapter();
        appointmentsTableAdapter appointments = new appointmentsTableAdapter();
        public A4()
        {
            InitializeComponent();
            PLAT.ItemsSource = payments.GetData();
            Combo.ItemsSource = appointments.GetData();
            Combo.DisplayMemberPath = "appointment_date";
            Combo.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            payments.InsertQuery(Convert.ToDecimal(T1.Text), T2.Text, Convert.ToInt32(Combo.SelectedValue));
            PLAT.ItemsSource = payments.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (PLAT.SelectedItem as DataRowView).Row[0];
            payments.DeleteQuery(Convert.ToInt32(id));
            PLAT.ItemsSource = payments.GetData();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (PLAT.SelectedItem as DataRowView).Row[0];
            payments.UpdateQuery(Convert.ToDecimal( T1.Text), T2.Text, Convert.ToInt32(Combo.SelectedValue), Convert.ToInt32(id));
            PLAT.ItemsSource = payments.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Role1 wim = new Role1();
            wim.Show();
        }
    }
}
