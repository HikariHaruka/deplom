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
    /// Логика взаимодействия для PageAddProduct.xaml
    /// </summary>
    public partial class PageAddProduct : Page
    {
        private Product _product = new Product();
        public PageAddProduct()
        {
            InitializeComponent();
            cbxTypeBallon.ItemsSource = DBPlanProductEntities.GetContext().Balloons.ToList();
            cbxTypeProduct.ItemsSource = DBPlanProductEntities.GetContext().ProductTypes.ToList();
            DataContext = _product;
        }

        private void btnAddProd_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddTypeProduct windowAddTypeProduct = new Windows.WindowAddTypeProduct();
            windowAddTypeProduct.Show();
        }

        private void btnAddBall_Click(object sender, RoutedEventArgs e)
        {
            Windows.WindowAddBallon windowAddBallon = new Windows.WindowAddBallon();
            windowAddBallon.Show();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_product.OneLine < 0 && tbx1Line.Text.All(char.IsDigit) != true)
            {
                errors.AppendLine("Укажите в поле 1 линия только положительные числа, без текста!");
            }
            if (_product.TwoLine < 0 && tbx2Line.Text.All(char.IsDigit) != true)
            {
                errors.AppendLine("Укажите в поле 2 линия только положительные числа, без текста!");
            }
            if (_product.ThreeLine < 0 && tbx3Line.Text.All(char.IsDigit) != true)
            {
                errors.AppendLine("Укажите в поле 3 линия только положительные числа, без текста!");
            }
            if(_product.ProductType==null) //не работает
            {
                errors.AppendLine("Выберите тип продукции!");
            }
            if (_product.Balloon == null) //не работает
            {
                errors.AppendLine("Выберите вид баллона!");
            }
            if(errors.Length>0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if(_product.Id==0)
            {
                DBPlanProductEntities.GetContext().Products.Add(_product);
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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Entities.ClassNavigation.StartFrame.Navigate(new Pages.PageProduct());
        }

       
    }
}
