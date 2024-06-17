using Diplom_Hospital.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Diplom_Hospital.Wind
{
    /// <summary>
    /// Логика взаимодействия для LogWriteOffWindow.xaml
    /// </summary>
    public partial class LogWriteOffWindow : Window
    {
        private MedicinaEntities context;
        private Balance selectedBalance;
        public LogWriteOffWindow(Balance selectedBalance)
        {
            InitializeComponent();
            context = MedicinaEntities.GetContext();
            tbId.Text = selectedBalance.Id.ToString();
            tbIdMedicine.Text = selectedBalance.IdMedicine.ToString();
            tbMedicineName.Text = selectedBalance.Medicine.MedicineName;
            tbDescription.Text = selectedBalance.Medicine.Description;
            tbCategory.Text = selectedBalance.Medicine.Category.NameCategory;
            tbQuantity.Text = selectedBalance.Quantity.ToString();
            tbIdEmployee.Text = LoginWindow.idEmp.ToString();
            this.selectedBalance=selectedBalance;
        }

        private void btnMakeOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                    context.Entry(selectedBalance).State = System.Data.Entity.EntityState.Modified;
                    var newLogWriteOff = new LogWriteOff
                    {
                        IdBalance = int.Parse(tbId.Text), // Используйте IdBalance, переданный в конструктор
                        DateWrite = dpDepartament.SelectedDate.Value,
                        QuantityWrite = int.Parse(tbQuantity.Text),
                        IdEmployee = int.Parse(tbIdEmployee.Text),
                        Reason = tbWriteOffReason.Text
                    };

                    context.LogWriteOff.Add(newLogWriteOff);
                    context.SaveChanges();
                    selectedBalance.IsDeleted = true;
                    context.Entry(selectedBalance).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                    MessageBox.Show("Данные о списании успешно добавлены!");
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
    }
}
