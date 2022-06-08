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
using System.Windows.Shapes;

namespace AeroProPlanProductionApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddTypeProduct.xaml
    /// </summary>
    public partial class WindowAddTypeProduct : Window
    {
        private ProductType _productType = new ProductType();
        public WindowAddTypeProduct(ProductType selectedProductType)
        {
            InitializeComponent();
            if (selectedProductType != null)
            {
                _productType = selectedProductType;
            }
            DataContext = _productType;
        }

        private void btnAddTypeProd_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (_productType.TypeProduct == null)
            {
                errors.AppendLine("Введите наименование типа продукта");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_productType.Id == 0)
            {
                if (cbxActuality.IsChecked == true)
                    _productType.Actuality = true;
                else _productType.Actuality = false;

                DBPlanProductEntities.GetContext().ProductTypes.Add(_productType);
            }
            try
            {
               // DBPlanProductEntities.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCloseAddTypeProd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
