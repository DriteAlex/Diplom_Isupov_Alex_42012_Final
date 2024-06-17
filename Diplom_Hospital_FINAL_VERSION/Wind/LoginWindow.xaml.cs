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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Diplom_Hospital
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        static public int idEmp;
        static public int idDepart;
        static public string serverName = Environment.MachineName;
        static public string connectionString;
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connectionString = $"Data Source={serverName}\\SQLEXPRESS;Initial Catalog=Medicina;Integrated Security=True";
                string login = tbLogin.Text;
                string password = tbPassword.Text;

                SqlHelper.IdEmployeeSelect(login,password);
                SqlHelper.IdDepartSelect();
                int accountCheck=SqlHelper.LoginAndPasswordCheck(login,password);
                if (accountCheck != 0) 
                {
                    LeadWindow lw = new LeadWindow();
                    lw.Show();
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Проверьте введенные логин и пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
