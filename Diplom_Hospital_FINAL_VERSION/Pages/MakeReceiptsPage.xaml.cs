using Diplom_Hospital.Model;
using Diplom_Hospital.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Diplom_Hospital.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogReceiptsPage.xaml
    /// </summary>
    public partial class MakeReceiptsPage : Page
    {
        private MedicinaEntities context;
        private static Orders medical;
        private static List<OrderDeyails> orderedMedicines;

        public MakeReceiptsPage()
        {
            InitializeComponent();
            context = MedicinaEntities.GetContext();
            cbOrderSelected.ItemsSource = context.Orders.ToList(); ;
            cbOrderSelected.SelectedIndex = 0;
            orderedMedicines = context.OrderDeyails.ToList();
            dgBalanceMedicine.ItemsSource = orderedMedicines;
        }

        private void tbSearh_TextChanged(object sender, TextChangedEventArgs e)
        {
            var currentMedicine = context.OrderDeyails.ToList();
            currentMedicine = currentMedicine.Where(p => p.IdOrder.ToString().ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Medicine.MedicineName.ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Medicine.Description.ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Medicine.Category.NameCategory.ToLower().Contains(tbSearh.Text.ToLower())).ToList();
            dgBalanceMedicine.ItemsSource = currentMedicine;

        }

        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {
            orderedMedicines = context.OrderDeyails.ToList();

            if (cbOrderSelected.SelectedIndex >= 0)
            {
                medical = cbOrderSelected.SelectedItem as Orders;
                if (medical != null)
                {
                    orderedMedicines = orderedMedicines.Where(p => p.IdOrder == medical.id).ToList();

                }

            }

            dgBalanceMedicine.ItemsSource = orderedMedicines;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            cbOrderSelected.SelectedIndex = 0;
            orderedMedicines = context.OrderDeyails.ToList();
            dgBalanceMedicine.ItemsSource = orderedMedicines;
        }

        private void btnAddMedicine_Click(object sender, RoutedEventArgs e)
        {
            context.Configuration.ValidateOnSaveEnabled = false; // Используем существующий контекст
            List<int> itemOrderDeyails = new List<int>();
            List<int> itemOrders = new List<int>();

            foreach (OrderDeyails item in dgBalanceMedicine.Items)
            {
                var implementationMonth = Methods.GetCellTextBoxValue(dgBalanceMedicine, item, 7);
                var implementationYear = Methods.GetCellTextBoxValue(dgBalanceMedicine, item, 8);
                DateTime? date = null;
                var cellValue = dgBalanceMedicine.Columns[1].GetCellContent(item);

                if (cellValue is FrameworkElement element)
                {
                    DatePicker datePicker = Methods.FindVisualChild<DatePicker>(element);
                    if (datePicker != null && datePicker.SelectedDate.HasValue)
                    {
                        date = datePicker.SelectedDate.Value;
                    }
                }

                if (date != null && !string.IsNullOrEmpty(implementationMonth) && !string.IsNullOrEmpty(implementationYear))
                {
                    LogOfReceipts newLog = new LogOfReceipts
                    {
                        IdMedicine = item.Medicine.Id,
                        QuantityReceipts = Convert.ToInt32(item.Quantity),
                        IdHospitalDepartament = Convert.ToInt32(item.Orders.IdDepartament),
                        DateRecepts = date.Value,
                        ImplementationMonth = implementationMonth.Substring(0, Math.Min(implementationMonth.Length, 10)),
                        ImplementationYear = implementationYear.Substring(0, Math.Min(implementationYear.Length, 10))
                    };
                    context.LogOfReceipts.Add(newLog);
                    Balance newBalance = new Balance
                    {
                        IdMedicine = item.Medicine.Id,
                        Quantity = Convert.ToInt32(item.Quantity),
                        IdHospitalDepartment = Convert.ToInt32(item.Orders.IdDepartament),
                        ImplementationMonth = implementationMonth.Substring(0, Math.Min(implementationMonth.Length, 10)),
                        ImplementationYear = implementationYear.Substring(0, Math.Min(implementationYear.Length, 10)),
                        IsDeleted = false
                    };
                        context.Balance.Add(newBalance);
                    // Добавляем Id записей, которые будут удалены
                    itemOrderDeyails.Add(item.id);
                    itemOrders.Add((int)item.IdOrder);
                }
                else
                {
                    MessageBox.Show("Проверьте все введенные значения");
                    return;
                }
            }
            // Удаляем записи из таблицы OrderDeyails по Id
            context.OrderDeyails.RemoveRange(context.OrderDeyails.Where(x => itemOrderDeyails.Contains(x.id)));
            List<int> uniqueItemOrders = itemOrders.Distinct().ToList();
            context.Orders.RemoveRange(context.Orders.Where(x => uniqueItemOrders.Contains(x.id)));
            context.SaveChanges();
            MessageBox.Show("Данные сохранены");
        }
    }
}
