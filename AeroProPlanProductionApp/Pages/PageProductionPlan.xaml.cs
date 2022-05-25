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
    /// Логика взаимодействия для PageProductionPlan.xaml
    /// </summary>
    public partial class PageProductionPlan : Page
    {
        private PlanProduction _planProd = new PlanProduction();
        public PageProductionPlan()
        {
            InitializeComponent();
            cbxProduct.ItemsSource = DBPlanProductEntities.GetContext().Products.ToList();
            DataContext = _planProd;
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Entities.ClassNavigation.StartFrame.Navigate(new Pages.PageAddProduct(null));
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (_planProd.QuantityOfProducts > 0 && tbxQuantity.Text.All(char.IsDigit) == true)
            {
                int quanProd = Convert.ToInt32(tbxQuantity.Text);
                int oneShif = 0;
                int quanShif;

                if (_planProd.Product.NameProduct != null)
                {
                    int prod = cbxProduct.SelectedIndex + 1;
                    if (chbx1Line.IsChecked == true)
                    {
                        int oneLine = Convert.ToInt32(Entities.DBPlanProductEntities.GetContext().Products.Single(p => p.Id == prod).OneLine);
                        if (oneLine > 0)
                        {
                            oneShif = +oneLine;
                        }
                    }
                    if (chbx2Line.IsChecked == true)
                    {
                        int twoLine = Convert.ToInt32(Entities.DBPlanProductEntities.GetContext().Products.Single(p => p.Id == prod).TwoLine);
                        if (twoLine > 0)
                        {
                            oneShif = +twoLine;
                        }
                    }
                    if (chbx3Line.IsChecked == true)
                    {
                        int threeLine = Convert.ToInt32(Entities.DBPlanProductEntities.GetContext().Products.Single(p => p.Id == prod).ThreeLine);
                        if (threeLine > 0)
                        {
                            oneShif = +threeLine;
                        }
                    }
                    if (oneShif < 1)
                    {
                        oneShif = 1;
                        quanShif = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(Convert.ToDouble(quanProd) / Convert.ToDouble(oneShif))));
                    }
                    else 
                    {
                        quanShif = Convert.ToInt32(Math.Ceiling(Convert.ToDecimal(Convert.ToDouble(quanProd) / Convert.ToDouble(oneShif))));
                    }
                    Windows.WindowPlanProduct windowPlanProduct = new Windows.WindowPlanProduct(prod,quanProd,quanShif);
                    windowPlanProduct.Show();
                }
            }
            

        }
        private void cbxProduct_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            TextBox search = sender as TextBox;
            if (search != null)
            {
                cbxProduct.ItemsSource = Entities.DBPlanProductEntities.GetContext().Products.Where(p => p.NameProduct.Contains(search.Text)).ToList();
            }
        }
    }
}
