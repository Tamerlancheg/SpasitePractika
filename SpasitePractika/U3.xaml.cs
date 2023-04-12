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
    public partial class U3 : Window
    {
        servicesTableAdapter services = new servicesTableAdapter();
        public U3()
        {
            InitializeComponent();
            USLUG.ItemsSource = services.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            services.InsertQuery(T1.Text,Convert.ToDecimal (T2.Text));
            USLUG.ItemsSource = services.GetData();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (USLUG.SelectedItem as DataRowView).Row[0];
            services.DeleteQuery(Convert.ToInt32(id));
            USLUG.ItemsSource = services.GetData();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (USLUG.SelectedItem as DataRowView).Row[0];
            services.UpdateQuery(T1.Text, Convert.ToDecimal(T2.Text),Convert.ToInt32(id));
            USLUG.ItemsSource = services.GetData();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Role2 wim = new Role2();
            wim.Show();
        }
    }
}
