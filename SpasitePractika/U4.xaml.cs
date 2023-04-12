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
    public partial class U4 : Window
    {
        reviewsTableAdapter reviews = new reviewsTableAdapter();
        appointmentsTableAdapter appointments= new appointmentsTableAdapter();
        salon_infoTableAdapter salon_Info= new salon_infoTableAdapter();
        public U4()
        {
            InitializeComponent();
            RATE.ItemsSource = reviews.GetData();
            Combo1.ItemsSource = appointments.GetData();
            Combo1.DisplayMemberPath = "appointment_date";
            Combo1.SelectedValuePath = "id";
            Combo2.ItemsSource = salon_Info.GetData();
            Combo2.DisplayMemberPath = "name";
            Combo2.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            reviews.InsertQuery(T1.Text, T2.Text, Convert.ToInt32(Combo2.SelectedValue), Convert.ToInt32(Combo1.SelectedValue));
            RATE.ItemsSource = reviews.GetData();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (RATE.SelectedItem as DataRowView).Row[0];
            reviews.DeleteQuery(Convert.ToInt32(id));
            RATE.ItemsSource = reviews.GetData();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (RATE.SelectedItem as DataRowView).Row[0];
            reviews.UpdateQuery(T1.Text, T2.Text, Convert.ToInt32(Combo2.SelectedValue), Convert.ToInt32(Combo1.SelectedValue), Convert.ToInt32(id));
            RATE.ItemsSource = reviews.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Role2 wim = new Role2();
            wim.Show();
        }
    }
}
