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
    /// Логика взаимодействия для PageTypeBalloon.xaml
    /// </summary>
    public partial class PageTypeBalloon : Page
    {
        public PageTypeBalloon()
        {
            InitializeComponent();
            dgBalloon.ItemsSource = DBPlanProductEntities.GetContext().Balloons.ToList();
        }

        private void btnAddTypeBalloon_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddBallon windowAddBallon = new Windows.WindowAddBallon(null);
            windowAddBallon.Show();
        }

        private void btnDelTypeBalloon_Click(object sender, RoutedEventArgs e)
        {
            var balloonsForRemoving = dgBalloon.SelectedItems.Cast<Balloon>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {balloonsForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DBPlanProductEntities.GetContext().Balloons.RemoveRange(balloonsForRemoving);
                    DBPlanProductEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dgBalloon.ItemsSource = DBPlanProductEntities.GetContext().Balloons.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddBallon windowAddBallon = new Windows.WindowAddBallon((sender as Button).DataContext as Balloon);
            windowAddBallon.Show();
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Entities.DBPlanProductEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dgBalloon.ItemsSource = Entities.DBPlanProductEntities.GetContext().Balloons.ToList();
            }
        }

        private void txbxSourse_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentBallons = Entities.DBPlanProductEntities.GetContext().Balloons.ToList();

            currentBallons = currentBallons.Where(p => p.NameBalloon.ToLower().Contains(txbxSourse.Text.ToLower())).ToList();
            dgBalloon.ItemsSource = currentBallons.ToList();
        }
    }
}
