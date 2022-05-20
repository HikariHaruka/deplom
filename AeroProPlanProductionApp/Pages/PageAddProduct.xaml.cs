﻿using System;
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
        public PageAddProduct()
        {
            InitializeComponent();
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

        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Entities.ClassNavigation.StartFrame.Navigate(new Pages.PageProduct());
        }
    }
}
