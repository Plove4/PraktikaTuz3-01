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
using PraktikaTuz3_01.Utiliites;
using PraktikaTuz3_01.Pages;
using PraktikaTuz3_01.Entities;

namespace PraktikaTuz3_01.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void EnterBtn_Click(object sender, RoutedEventArgs e)
        {
            if (Logintext.Text == "" || Paswtext.Text == "")
            {
                MessageBox.Show("Нужно задать логин и пороль");
                return;
            }

            Users usr = DBContext.Context.Users.FirstOrDefault(u => u.login == Logintext.Text && u.password == Paswtext.Text);

            if (usr != null)
            {
                switch (usr.roleId)
                {
                    case 1:
                        FrameManeger.frmMain.Navigate(new DirectorPage());
                        break;

                    case 2:
                        FrameManeger.frmMain.Navigate(new ManegerPage());
                        break;

                    case 3:
                        FrameManeger.frmMain.Navigate(new AdminPage());
                        break;
                }
            }
            else
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
        }
    }
}
