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
        public PageAddUser()
        {
            InitializeComponent();
            cbxRole.ItemsSource = DBPlanProductEntities.GetContext().Roles.ToList();
            DataContext = _user;
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (txbxLastName.Text != null)
            {
                if (txbxLastName.Text.All(char.IsLetter) != true)
                {
                    errors.AppendLine("Фамилия должна состоять только из букв");
                }
            }
            else errors.AppendLine("Введите фамилию");

            if (txbxFirstName.Text != null)
            {
                if (txbxFirstName.Text.All(char.IsLetter) != true)
                {
                    errors.AppendLine("Имя должно состоять только из букв");
                }
            }
            else errors.AppendLine("Введите имя");

            if (txbxPatronymic.Text.All(char.IsLetter) != true)
            {
                errors.AppendLine("Отчество должно состоять только из букв");
            }

            if (_user.Role == null)
            {
                errors.AppendLine("Выберите роль пользователя");
            }

            if (txbxLogin.Text != null)
            {
                if (txbxLogin.Text.All(char.IsWhiteSpace) == true)
                {
                    errors.AppendLine("Логин не должен содержать пробелов");
                }

            }
            else errors.AppendLine("Введите логин");

            if (txbxPass.Text != null)
            {
                if (txbxPass.Text.Length >= 5)
                {
                    bool en = true;
                    bool symbol = false;
                    bool number = false;

                    for (int i = 0; i < txbxPass.Text.Length; i++)
                    {
                        if (txbxPass.Text[i] >= 'А' && txbxPass.Text[i] <= 'Я') en = false;
                        if (txbxPass.Text[i] >= '0' && txbxPass.Text[i] <= '9') number = true;
                        if (txbxPass.Text[i] == '_' || txbxPass.Text[i] == '$' || txbxPass.Text[i] == '!') symbol = true;
                    }

                    if (en != true) errors.AppendLine("Доступна только английская раскладка в пароле");
                    if (symbol != true) errors.AppendLine("Добавьте хотя бы один из следующих символов в пароль : _, $, !");
                    if (number != true) errors.AppendLine("Добавьте хотя бы одну цифру в пароль");
                }
                else errors.AppendLine("Пароль слишком короткий, минимум 5 символов");
            }
            else errors.AppendLine("Введите пароль");


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

        }

        private void btnWatchPass_Click(object sender, RoutedEventArgs e)
        {
            if (pbxPass.Visibility == Visibility.Visible)
            {
                txbxPass.Visibility = Visibility.Visible;
                pbxPass.Visibility = Visibility.Hidden;
                txbxPass.Text = pbxPass.Password;
            }
            else
            {
                pbxPass.Visibility = Visibility.Visible;
                txbxPass.Visibility = Visibility.Hidden;
                pbxPass.Password = txbxPass.Text;
            }
        }
    }
}
