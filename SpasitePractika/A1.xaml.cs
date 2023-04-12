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
    public partial class A1 : Window
    {
        customersTableAdapter customers = new customersTableAdapter();
        public A1()
        {
            InitializeComponent();
            CUS.ItemsSource = customers.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            customers.InsertQuery(T1.Text, T2.Text, T3.Text, T4.Text, T5.Text, T6.Text);
            CUS.ItemsSource = customers.GetData();
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            object id = (CUS.SelectedItem as DataRowView).Row[0];
            customers.DeleteQuery(Convert.ToInt32(id));
            CUS.ItemsSource = customers.GetData();
        }

        private void B3_Click(object sender, RoutedEventArgs e)
        {
            object id = (CUS.SelectedItem as DataRowView).Row[0];
            customers.UpdateQuery(T1.Text, T2.Text, T3.Text, T4.Text, T5.Text, T6.Text,Convert.ToInt32(id));
            CUS.ItemsSource = customers.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Role1 wim = new Role1();
            wim.Show();
        }
    }
}
