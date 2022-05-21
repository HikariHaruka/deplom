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
    /// Логика взаимодействия для PageHistoryLogin.xaml
    /// </summary>
    public partial class PageHistoryLogin : Page
    {
        public PageHistoryLogin()
        {
            InitializeComponent();
            dgHistoryLog.ItemsSource = DBPlanProductEntities.GetContext().HistoryLogins.ToList();
        }
    }
}
