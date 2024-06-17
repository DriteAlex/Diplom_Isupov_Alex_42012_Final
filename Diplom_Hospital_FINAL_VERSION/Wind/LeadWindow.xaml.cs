using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Diplom_Hospital.Classes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Diplom_Hospital
{
    /// <summary>
    /// Логика взаимодействия для LeadWindow.xaml
    /// </summary>
    public partial class LeadWindow : Window
    {
        public LeadWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Pages.MedicinePage());
            Manager.MainFrame = MainFrame;
        }

        private void btnOrders_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.OrderPage());
            Manager.MainFrame = MainFrame;

        }

        private void btnMakeReceipts_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.MakeReceiptsPage());
            Manager.MainFrame = MainFrame;
        }

        private void btnLogOfReceipts_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.LogOfReceiptsPage());
            Manager.MainFrame = MainFrame;
        }
        private void btnLogWriteOff_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.LogWriteOffPage());
            Manager.MainFrame = MainFrame;
        }

        private void btnMainPage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Pages.MedicinePage());
            Manager.MainFrame = MainFrame;
        }
    }
}
