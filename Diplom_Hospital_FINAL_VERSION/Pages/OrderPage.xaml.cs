using Diplom_Hospital.Wind;
using Diplom_Hospital.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Diplom_Hospital.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Data;
using System.Collections;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;


namespace Diplom_Hospital.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        private static Category medical;
        private static List<Medicine> medicines;
        public OrderPage()
        {
            InitializeComponent();
            cbCategory.ItemsSource = MedicinaEntities.GetContext().Category.ToList();
            cbCategory.SelectedIndex = 0;
            medicines = MedicinaEntities.GetContext().Medicine.ToList();
            dgMedicine.ItemsSource = medicines;

            
        }
        private void tbSearh_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchText = tbSearh.Text;
            var currentMedicine = MedicinaEntities.GetContext().Medicine.ToList();
            currentMedicine = currentMedicine.Where(p => p.MedicineName.ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Category.NameCategory.ToLower().Contains(tbSearh.Text.ToLower()) ||
            p.Description.ToLower().Contains(tbSearh.Text.ToLower())).ToList();
            dgMedicine.ItemsSource = currentMedicine;
        }

        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {

            medicines = MedicinaEntities.GetContext().Medicine.ToList();

            if (cbCategory.SelectedIndex >= 0)
            {
                medical = cbCategory.SelectedItem as Category;
                if (medical != null)
                {
                    medicines = medicines.Where(p => p.Category.Id == medical.Id).ToList();

                }

            }
            
            dgMedicine.ItemsSource = medicines;
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            cbCategory.SelectedIndex = 0;
            medicines = MedicinaEntities.GetContext().Medicine.ToList();
            dgMedicine.ItemsSource = medicines;
        }

        private void btnOrderBasket_Click(object sender, RoutedEventArgs e)
        {
            if (dgMedicine.SelectedItems.Count>0)
            {
                MedicinaEntities _context = MedicinaEntities.GetContext();
                Orders orders = new Orders
                {
                    DateOrder = DateTime.Now,
                    IdDepartament = LoginWindow.idDepart,
                    IdEmployee = LoginWindow.idEmp
                };

                _context.Orders.Add(orders);

                _context.SaveChanges();
                int idOrder = 0;
                using (var connection = new SqlConnection(LoginWindow.connectionString))
                {
                    connection.Open();

                    var command = new SqlCommand("SELECT MAX(Id) FROM Orders", connection);

                    var result = command.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        idOrder = Convert.ToInt32(result);
                    }

                    connection.Close();
                }

                MedicinaEntities context = MedicinaEntities.GetContext();
                foreach (Medicine selectedMedicine in dgMedicine.SelectedItems)
                {
                    int selectedMedicineId = selectedMedicine.Id;

                    OrderDeyails newOrderDetail = new OrderDeyails
                    {
                        IdOrder = idOrder,
                        IdMedicine = selectedMedicineId,
                    };

                    context.OrderDeyails.Add(newOrderDetail);
                }
                context.SaveChanges();

                OrderBasketWindow ob = new OrderBasketWindow(idOrder);
                ob.Show();
            }

            else
            {
                MessageBox.Show("Выберите что вы хотите заказать и нажмите кнопку еще раз");
            }
        }
        

        
    }
}
