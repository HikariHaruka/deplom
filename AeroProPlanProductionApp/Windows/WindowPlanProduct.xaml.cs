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
using AeroProPlanProductionApp.Entities;

namespace AeroProPlanProductionApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowPlanProduct.xaml
    /// </summary>
    public partial class WindowPlanProduct : Window
    {
        public int idProduct;
        public int quanProduct;
        public int quanShifts;
        public WindowPlanProduct(int idProd, int quanProd, int quanShif)
        {
            InitializeComponent();
            idProduct = idProd;
            quanShifts = quanShif;
            quanProduct = quanProd;
            txblProd.Text = Entities.DBPlanProductEntities.GetContext().Products.Single(p => p.Id == idProd).NameProduct;
            txblQuanProd.Text = Convert.ToString(quanProd);
            txblQuanShif.Text = Convert.ToString(quanShif);
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            PlanProduction planProduction = new PlanProduction();
            planProduction.IdProduct = idProduct;
            planProduction.QuantityOfProducts = quanProduct;
            planProduction.QuantityOfShifts = quanShifts;
            DBPlanProductEntities.GetContext().PlanProductions.Add(planProduction);
            DBPlanProductEntities.GetContext().SaveChanges();
            MessageBox.Show("Данные сохранены");
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog p = new PrintDialog();
            if (p.ShowDialog() == true)
            {
                p.PrintVisual(grPrint, "Производственный план");
            }
        }
    }
}
