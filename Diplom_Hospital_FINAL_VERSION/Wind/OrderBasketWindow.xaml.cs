using Diplom_Hospital.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using Diplom_Hospital.Pages;
using Diplom_Hospital.Model;
using System.Data;
using System.Runtime.Remoting.Contexts;
using System.Net;
using System.Xml.Linq;

namespace Diplom_Hospital.Wind
{
    /// <summary>
    /// Логика взаимодействия для OrderBasketWindow.xaml
    /// </summary>
    public partial class OrderBasketWindow : Window
    {
        private int idOrderNow;
        public OrderBasketWindow(int idOrderNow)
        {
            InitializeComponent();
            var context = MedicinaEntities.GetContext();
            dgSelectedMedicines.ItemsSource = context.OrderDeyails.Where(detail => detail.IdOrder == idOrderNow).ToList();
            this.idOrderNow = idOrderNow;
        }

        private void btnMakeOrder_Click(object sender, RoutedEventArgs e)
        {
            foreach (var item in dgSelectedMedicines.Items)
            {
                var row = item as OrderDeyails;    
                if (row != null)
                {
                    int quantity = Convert.ToInt32(row.Quantity);
                    int idMedicine = Convert.ToInt32(row.IdMedicine);
                    int idOrder = idOrderNow; 

                    if (quantity != 0 && quantity > 0)
                    {
                        // Обновление данных в базе данных
                        SqlHelper.OrderDeyailsUpdate(idOrder,idMedicine,quantity);
                    }
                    else
                    {
                        MessageBox.Show("Введите кол-во медикаментов, которое хотите заказать");
                    }
                }
            }
            MessageBox.Show("Данные обновлены в базе данных.");
            Close();
        }
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnNewPdf_Click(object sender, RoutedEventArgs e)
        {
            Methods.NewPdfReportOrderBasket(dgSelectedMedicines, "ОТЧЕТ О ЗАКАЗАННЫХ ЛЕКАРСТВАХ ", "Корзина с препаратами", $"Корзина_заказа_{DateTime.Today.ToShortDateString()}");
        }
    }
}
