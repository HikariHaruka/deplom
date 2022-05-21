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

        }

        private void btnAddTypeProd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelTypeProd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
