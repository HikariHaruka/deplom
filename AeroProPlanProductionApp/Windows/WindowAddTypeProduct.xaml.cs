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
        public WindowAddTypeProduct()
        {
            InitializeComponent();
        }

        private void btnAddTypeProd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCloseAddTypeProd_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
