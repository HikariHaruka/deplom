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
        public PageProductionPlan()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            Entities.ClassNavigation.StartFrame.Navigate(new Pages.PageAddProduct());
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbxTypeProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cbxTypeBallon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
