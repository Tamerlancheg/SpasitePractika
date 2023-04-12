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
    
  
    public partial class NewRole : Window
    {
        LoginDataTableAdapter LoginData = new LoginDataTableAdapter();
        RoleTableAdapter Gol= new RoleTableAdapter();
        public NewRole()
        {
            InitializeComponent();
            REG.ItemsSource = LoginData.GetData();
            Combo.ItemsSource = Gol.GetData();
            Combo.DisplayMemberPath = "name";
            Combo.SelectedValuePath = "id";
        }

    

        private void But_Click(object sender, RoutedEventArgs e)
        {
            LoginData.InsertQuery(Convert.ToString(T1.Text), Convert.ToInt32(T2.Text), Convert.ToInt32(Combo.SelectedValue));
            REG.ItemsSource = LoginData.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Role1 wim = new Role1();
            wim.Show();
        }
    }
}
