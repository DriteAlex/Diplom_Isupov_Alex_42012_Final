using Diplom_Hospital.Classes;
using Diplom_Hospital.Wind;
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
using static System.Net.Mime.MediaTypeNames;
using Diplom_Hospital.Model;

namespace Diplom_Hospital.Pages
{
    /// <summary>
    /// Логика взаимодействия для MedicinePage.xaml
    /// </summary>
    public partial class MedicinePage : Page
    {
        public MedicinePage()
        {
            InitializeComponent();
            dgMedicine.ItemsSource = MedicinaEntities.GetContext().Balance.Where(b => (bool)!b.IsDeleted).ToList();
        }

        private void btnWriteOff_Click(object sender, RoutedEventArgs e)
        {
            var selectedBalance = (sender as Button).DataContext as Balance;
            if (selectedBalance != null)
            {
                // Создаем и отображаем LogWriteOffWindow
                new LogWriteOffWindow(selectedBalance).Show();
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            var applicationsForRemoving = dgMedicine.SelectedItems.Cast<Balance>().ToList();

            try
            {
                using (var context = MedicinaEntities.GetContext())
                {
                    foreach (var balance in applicationsForRemoving)
                    {
                        balance.IsDeleted = true;
                        context.Entry(balance).State = System.Data.Entity.EntityState.Modified;
                    }

                    context.SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    dgMedicine.ItemsSource = context.Balance.Where(b => (bool)!b.IsDeleted).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

       
    }
}
