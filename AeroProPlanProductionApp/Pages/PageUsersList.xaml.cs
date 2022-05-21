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
    /// Логика взаимодействия для PageUsersList.xaml
    /// </summary>
    public partial class PageUsersList : Page
    {
        public PageUsersList()
        {
            InitializeComponent();
            dgUsers.ItemsSource = DBPlanProductEntities.GetContext().Users.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            Entities.ClassNavigation.StartFrame.Navigate(new Pages.PageAddUser());
        }

        private void btnDelUser_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
