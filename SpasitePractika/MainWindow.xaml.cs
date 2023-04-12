using SpasitePractika.msdbDataSetTableAdapters;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpasitePractika
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginDataTableAdapter kluch = new LoginDataTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var ALLOGINS = kluch.GetData().Rows;
            for(int i = 0;i<ALLOGINS.Count;i++)
            {
                if (ALLOGINS[i][1].ToString() == login.Text && ALLOGINS[i][2].ToString() == password.Password)
                {
                    int roleid = (int)ALLOGINS[i][3];
                    switch(roleid)
                    {
                        case 1:
                            Role1 role = new Role1();
                            role.Show();
                            break;

                        case 2:
                            Role2 roletoo = new Role2();
                            roletoo.Show();
                            break;

                    }

                }



            }

        }
    }
}
