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
            Entities.ClassNavigation.StartFrame.Navigate(new PageAddUser((sender as Button).DataContext as User));
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            Entities.ClassNavigation.StartFrame.Navigate(new Pages.PageAddUser(null));
        }

        private void btnDelUser_Click(object sender, RoutedEventArgs e)
        {
            var usersForRemoving = dgUsers.SelectedItems.Cast<User>().ToList();

            if(MessageBox.Show($"Вы точно хотите удалить следующие {usersForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo,MessageBoxImage.Question)==MessageBoxResult.Yes)
            {
                try
                {
                    DBPlanProductEntities.GetContext().Users.RemoveRange(usersForRemoving);
                    DBPlanProductEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dgUsers.ItemsSource = DBPlanProductEntities.GetContext().Users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
