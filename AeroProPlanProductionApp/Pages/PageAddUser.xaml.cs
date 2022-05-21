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
        public PageAddUser()
        {
            InitializeComponent();
            cbxRole.ItemsSource = DBPlanProductEntities.GetContext().Roles.ToList();
        }

        private void btnSaveUser_Click(object sender, RoutedEventArgs e)
        {

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
