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
    /// Логика взаимодействия для PageTypeProduct.xaml
    /// </summary>
    public partial class PageTypeProduct : Page
    {
        public PageTypeProduct()
        {
            InitializeComponent();
            dgTypeProd.ItemsSource = DBPlanProductEntities.GetContext().ProductTypes.ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddTypeProduct windowAddTypeProduct = new Windows.WindowAddTypeProduct((sender as Button).DataContext as ProductType);
            windowAddTypeProduct.Show();
        }

        private void btnAddTypeProd_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddTypeProduct windowAddTypeProduct = new Windows.WindowAddTypeProduct(null);
            windowAddTypeProduct.Show();
        }

        private void btnDelTypeProd_Click(object sender, RoutedEventArgs e)
        {
            var productTypesForRemoving = dgTypeProd.SelectedItems.Cast<Balloon>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {productTypesForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    DBPlanProductEntities.GetContext().Balloons.RemoveRange(productTypesForRemoving);
                    DBPlanProductEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    dgTypeProd.ItemsSource = DBPlanProductEntities.GetContext().Balloons.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Entities.DBPlanProductEntities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                dgTypeProd.ItemsSource = Entities.DBPlanProductEntities.GetContext().ProductTypes.ToList();
            }
        }

        private void txbxSourse_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentTypeProd = Entities.DBPlanProductEntities.GetContext().ProductTypes.ToList();

            currentTypeProd = currentTypeProd.Where(p => p.TypeProduct.ToLower().Contains(txbxSourse.Text.ToLower())).ToList();
            dgTypeProd.ItemsSource = currentTypeProd.ToList();
        }
    }
}
