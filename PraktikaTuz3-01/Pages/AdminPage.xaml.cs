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
using PraktikaTuz3_01.Entities;
using PraktikaTuz3_01.Utiliites;

namespace PraktikaTuz3_01.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        private Users menuser;
        public AdminPage(Users users)
        {
            InitializeComponent();

            menuser = users;

            Hellotext.Text = $"Добро пожаловать, {menuser?.FIO}!";

            this.Title = $"Меню {menuser?.Roles.name}";
        }

        private void AccountButn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddButn_Click(object sender, RoutedEventArgs e)
        {
            FrameManeger.frmMain.Navigate(new AddUserPage(null));
        }
    }
}
