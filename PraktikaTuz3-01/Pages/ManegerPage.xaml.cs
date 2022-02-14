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

namespace PraktikaTuz3_01.Pages
{
    /// <summary>
    /// Логика взаимодействия для ManegerPage.xaml
    /// </summary>
    public partial class ManegerPage : Page
    {
        private Users menuUser;
        public ManegerPage(Users users)
        {
            InitializeComponent();

            menuUser = users;

            Hellotext.Text = $"Добро пожаловать, {menuUser?.FIO}!";

            this.Title = $"Меню {menuUser?.Roles.name}";
        }
    }
}
