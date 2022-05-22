using AeroProPlanProductionApp.Entities;
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

namespace AeroProPlanProductionApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddUser.xaml
    /// </summary>
    public partial class PageAddUser : Page
    {
        private User _user = new User();
        public PageAddUser(User selectedUser)
        {
            InitializeComponent();

            if (selectedUser != null)
                _user = selectedUser;

            cbxRole.ItemsSource = DBPlanProductEntities.GetContext().Roles.ToList();
            DataContext = _user;
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_user.LastName))
            {
                errors.AppendLine("Введите фамилию");
            }

            if (string.IsNullOrWhiteSpace(_user.FirstName))
            {
                errors.AppendLine("Введите имя");
            }

            if (_user.Role == null)
            {
                errors.AppendLine("Выберите роль пользователя");
            }

            if (string.IsNullOrWhiteSpace(_user.Login))
            {
                errors.AppendLine("Введите логин");
            }

            if (string.IsNullOrWhiteSpace(_user.Password))
            {
                errors.AppendLine("Введите пароль");
            }
            else
            {
                if (_user.Password.Length >= 5)
                {
                    bool en = true;
                    bool symbol = false;
                    bool number = false;

                    for (int i = 0; i < _user.Password.Length; i++)
                    {
                        if (_user.Password[i] >= 'А' && _user.Password[i] <= 'Я') en = false;
                        if (_user.Password[i] >= '0' && _user.Password[i] <= '9') number = true;
                        if (_user.Password[i] == '_' || _user.Password[i] == '$' || _user.Password[i] == '!') symbol = true;
                    }

                    if (en != true) errors.AppendLine("Доступна только английская раскладка в пароле");
                    if (symbol != true) errors.AppendLine("Добавьте хотя бы один из следующих символов в пароль : _, $, !");
                    if (number != true) errors.AppendLine("Добавьте хотя бы одну цифру в пароль");
                }
                else errors.AppendLine("Пароль слишком короткий, минимум 5 символов");
            } 


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_user.Id == 0)
            {
                DBPlanProductEntities.GetContext().Users.Add(_user);
            }
            try
            {
                DBPlanProductEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Entities.ClassNavigation.StartFrame.Navigate(new PageUsersList());
        }
        
    }
}
