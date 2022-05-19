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
        public static User authUser = null;

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
            Entities.User authUser = null;
            using (DBPlanProductEntities db = new DBPlanProductEntities())
            {
                authUser = db.Users.Where(b => b.Login == txbxLogin.Text && b.Password == pbxPassword.Password || b.Password == txbxPassword.Text).FirstOrDefault();
                if (authUser != null)
                {
                    Entities.ClassUser.userLastName = authUser.LastName;
                    Entities.ClassUser.userFirstName = authUser.FirstName;
                    Entities.ClassUser.userPathronimic = authUser.Patronymic;
                    Entities.ClassUser.userRole = authUser.Role.Type;
                   
                    var Id = authUser.Id;
                    
                    SaveHistory(Id);
                    StartWindow startWindow = new StartWindow();
                    startWindow.Show();
                    this.Close();

                }
                else
                    MessageBox.Show("Введен неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }
    

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private static void SaveHistory(int Id)
        {
            HistoryLogin history = new HistoryLogin();
            history.IdUser = Id;
            history.DateTime = DateTime.Now;
            DBPlanProductEntities.GetContext().HistoryLogins.Add(history);
            DBPlanProductEntities.GetContext().SaveChanges();
        }
    }
}
