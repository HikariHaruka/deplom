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
    /// Логика взаимодействия для WindowAddBallon.xaml
    /// </summary>
    public partial class WindowAddBallon : Window
    {
        public Balloon balloon = new Balloon();
        public WindowAddBallon(Balloon selectedBalloon)
        {
            InitializeComponent();
            
            if(selectedBalloon!=null)
            {
                balloon = selectedBalloon;
            }

            DataContext = balloon;
        }

        private void btnAddBall_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (balloon.Diameter < 0 && txbxDimBal.Text.All(char.IsDigit) != true)
            {
                errors.AppendLine("Укажите в поле диаметер только положительные числа, без текста!");
            }
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (balloon.Id == 0)
            {
                if (cbxActuality.IsChecked == true)
                    balloon.Actuality = true;
                else balloon.Actuality = false;

                DBPlanProductEntities.GetContext().Balloons.Add(balloon);
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

        private void btnCloseAddBall_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
