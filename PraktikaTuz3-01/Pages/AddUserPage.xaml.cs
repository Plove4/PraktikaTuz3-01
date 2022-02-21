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
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        private Users currentUser;
        public AddUserPage(Users users)
        {
            InitializeComponent();
            currentUser = users ?? new Users();
            CmbRole.ItemsSource = DBContext.Context.Roles.ToList();
            DataContext = currentUser;
        }

        private void RegistButn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentUser.login))
                builder.AppendLine("Укажите Логин");
            if (string.IsNullOrWhiteSpace(currentUser.password))
                builder.AppendLine("Укажите Пароль");
            if (string.IsNullOrWhiteSpace(currentUser.FIO))
                builder.AppendLine("Укажите Фамилию Имя Отчество");
            if (currentUser.Roles == null)
                builder.AppendLine("Укажите роль пользователя");

            if (builder.Length > 0)
            {
                MessageBox.Show(builder.ToString());
                return;
            }

            try
            {
                DBContext.Context.Users.Add(currentUser);
                DBContext.Context.SaveChanges();
                MessageBox.Show("Данные сохранены");
                FrameManeger.frmMain.Navigate(new LoginPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void ExitButn_Click(object sender, RoutedEventArgs e)
        {
            FrameManeger.frmMain.GoBack();
        }
    }
}
