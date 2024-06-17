using Diplom_Hospital.Classes;
using Diplom_Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Diplom_Hospital.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogOfReceiptsPage.xaml
    /// </summary>
    public partial class LogOfReceiptsPage : Page
    {
        private MedicinaEntities context;
        private static Category medical;
        private static List<LogOfReceipts> orderedMedicines;
        private static List<LogOfReceipts> medicines;
        public LogOfReceiptsPage()
        {
            InitializeComponent();
            context = MedicinaEntities.GetContext();
            cbCategory.ItemsSource = MedicinaEntities.GetContext().Category.ToList(); ;
            cbCategory.SelectedIndex = 0;
            orderedMedicines = MedicinaEntities.GetContext().LogOfReceipts.ToList();
            dgBalanceMedicine.ItemsSource = orderedMedicines;
        }

        private void tbSearh_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentMedicine = context.LogOfReceipts.ToList();
            currentMedicine = currentMedicine.Where(p => p.IdMedicine.ToString().ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.DateRecepts.ToString().ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Medicine.MedicineName.ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Medicine.Description.ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Medicine.Category.NameCategory.ToLower().Contains(tbSearh.Text.ToLower())).ToList();
            dgBalanceMedicine.ItemsSource = currentMedicine;

        }

        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {

            medicines = context.LogOfReceipts.ToList();

            if (cbCategory.SelectedIndex >= 0)
            {
                medical = cbCategory.SelectedItem as Category;
                if (medical != null)
                {
                    medicines = medicines.Where(p => p.Medicine.IdCategory == medical.Id).ToList();

                }

            }

            dgBalanceMedicine.ItemsSource = medicines;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            cbCategory.SelectedIndex = 0;
            orderedMedicines = context.LogOfReceipts.ToList();
            dgBalanceMedicine.ItemsSource = orderedMedicines;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Methods.NewPdfReportLogRecept(dgBalanceMedicine, "ОТЧЕТ О ПОСТУПИВШИХ ЛЕКАРСТВАХ ", "Список лекарств", $"Отчет_о_поступивших_лекарствах_{DateTime.Today.ToShortDateString()}");
        }
    }
}
