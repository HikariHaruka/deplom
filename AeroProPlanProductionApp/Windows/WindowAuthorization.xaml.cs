using AeroProPlanProductionApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AeroProPlanProductionApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAuthorization.xaml
    /// </summary>
    public partial class WindowAuthorization : Window
    {
        public WindowAuthorization()
        {
            InitializeComponent();
        }

        public int userId = 0;
        private int countErrorAvtoriz = 0;

        private void btnWatchPass_Click(object sender, RoutedEventArgs e)
        {
            if(pbxPassword.Visibility == Visibility.Visible)
            {
                txbxPassword.Visibility = Visibility.Visible;
                pbxPassword.Visibility = Visibility.Hidden;
                txbxPassword.Text = pbxPassword.Password;
            }
            else
            {
                pbxPassword.Visibility = Visibility.Visible;
                txbxPassword.Visibility = Visibility.Hidden;
                pbxPassword.Password = txbxPassword.Text;
            }
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            /*int count = 0;
            foreach (var user in DBPlanProductEntities._context.Users)
            {
                count++;
                if (txbxLogin.Text == user.Login && (pbxPassword.Password == user.Password || txbxPassword.Text==user.Password))
                {

                    userId = user.Id;
                    MessageBox.Show("Вы успешно авторизованы.", "Информация!", MessageBoxButton.OK, MessageBoxImage.Information);*/
                    StartWindow startWindow = new StartWindow();
                    startWindow.Show();
                   // count = 0;
                    this.Close();
                   /* break;
                }
                if (txbxLogin.Text == user.Login)
                {
                    userId = user.Id;
                }

            }
            if (count != 0)
            {
                MessageBox.Show("Логин или пароль не верны!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Warning);
                countErrorAvtoriz++;
            }
            if (countErrorAvtoriz == 3)
            {
                countErrorAvtoriz = 0;
                MessageBox.Show("", "", MessageBoxButton.OK, MessageBoxImage.Warning);
                Thread.Sleep(10000);
            }*/

        }
    

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
