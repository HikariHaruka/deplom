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
    /// Логика взаимодействия для PageUser.xaml
    /// </summary>
    public partial class PageUser : Page
    {
        public PageUser()
        {
            InitializeComponent();
            txbxFIO.Text = Entities.ClassUser.userLastName + " " + Entities.ClassUser.userFirstName + " " + Entities.ClassUser.userPathronimic;
            txbxRole.Text = Entities.ClassUser.userRole;
            if (Entities.ClassUser.userRole=="Главный технолог")
            {
                imgGlavTeh.Visibility = Visibility.Visible;
                imgTeh.Visibility = Visibility.Hidden;
                
            }
            else
            {
                imgGlavTeh.Visibility = Visibility.Hidden;
                imgTeh.Visibility = Visibility.Visible;
                
            }
        }

    }
}
