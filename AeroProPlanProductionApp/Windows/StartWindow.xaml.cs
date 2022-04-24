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
    /// Логика взаимодействия для StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();

            StartFrame.Navigate(new Pages.PageUser());
            Entities.ClassNavigation.StartFrame = StartFrame;
        }

        private void btnCalcPlanProduct_Click(object sender, RoutedEventArgs e)
        {
            StartFrame.Navigate(new Pages.PageProductionPlan());
            Entities.ClassNavigation.StartFrame = StartFrame;
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            StartFrame.Navigate(new Pages.PageProduct());
            Entities.ClassNavigation.StartFrame = StartFrame;
        }

        private void btnBackYes_Click(object sender, RoutedEventArgs e)
        {
            StartFrame.GoBack();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void StartFrame_ContentRendered(object sender, EventArgs e)
        {
            if (StartFrame.CanGoBack)
            {
                btnBackYes.Visibility = Visibility.Visible;
                btnBackNo.Visibility = Visibility.Hidden;
            }
            else
            {
                btnBackYes.Visibility = Visibility.Hidden;
                btnBackNo.Visibility = Visibility.Visible;
            }
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            StartFrame.Navigate(new Pages.PageUser());
            Entities.ClassNavigation.StartFrame = StartFrame;
        }

        private void btnAdmin_Click(object sender, RoutedEventArgs e)
        {
            StartFrame.Navigate(new Pages.PageAdmin());
            Entities.ClassNavigation.StartFrame = StartFrame;
        }
    }
}
