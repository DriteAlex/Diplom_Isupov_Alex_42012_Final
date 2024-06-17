using Diplom_Hospital.Classes;
using Diplom_Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Diplom_Hospital.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogWriteOffPage.xaml
    /// </summary>
    public partial class LogWriteOffPage : Page
    {
        private MedicinaEntities context;
        private static Category medical;
        private static List<LogWriteOff> orderedMedicines;
        private static List<LogWriteOff> medicines;
        public LogWriteOffPage()
        {
            InitializeComponent();
            context = MedicinaEntities.GetContext();
            cbCategory.ItemsSource = MedicinaEntities.GetContext().Category.ToList(); ;
            cbCategory.SelectedIndex = 0;
            orderedMedicines = MedicinaEntities.GetContext().LogWriteOff.ToList();
            dgWriteOffMedicine.ItemsSource = orderedMedicines;
        }

        private void tbSearh_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentMedicine = context.LogWriteOff.ToList();
            currentMedicine = currentMedicine.Where(p => p.IdBalance.ToString().ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.DateWrite.ToString().ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.QuantityWrite.ToString().ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Balance.Medicine.MedicineName.ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Balance.Medicine.Description.ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.IdEmployee.ToString().ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Balance.Medicine.Category.NameCategory.ToLower().Contains(tbSearh.Text.ToLower())).ToList();
            dgWriteOffMedicine.ItemsSource = currentMedicine;

        }

        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {

            medicines = context.LogWriteOff.ToList();

            if (cbCategory.SelectedIndex >= 0)
            {
                medical = cbCategory.SelectedItem as Category;
                if (medical != null)
                {
                    medicines = medicines.Where(p => p.Balance.Medicine.IdCategory == medical.Id).ToList();

                }

            }

            dgWriteOffMedicine.ItemsSource = medicines;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            cbCategory.SelectedIndex = 0;
            orderedMedicines = context.LogWriteOff.ToList();
            dgWriteOffMedicine.ItemsSource = orderedMedicines;
        }

        
    }
}
