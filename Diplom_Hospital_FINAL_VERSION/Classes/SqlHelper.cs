using Diplom_Hospital.Model;
using iTextSharp.text.pdf;
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

namespace Diplom_Hospital.Classes
{
    internal class SqlHelper
    {
        //Методы для окна LoginWindow
        public static void IdEmployeeSelect(string login,string password)
        {
            using (SqlConnection connection = new SqlConnection(LoginWindow.connectionString))
            {
                connection.Open();
                string query = "SELECT IdEmployee FROM Users WHERE Login = @Login AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    LoginWindow.idEmp = Convert.ToInt32(result);
                }
                connection.Close();
            }
        }

        public static void IdDepartSelect()
        {
            using (var connection = new SqlConnection(LoginWindow.connectionString))
            {
                connection.Open();
                var command = new SqlCommand("SELECT IdHospitalDepartment FROM Employee WHERE Id = @Id", connection);
                command.Parameters.AddWithValue("@Id", LoginWindow.idEmp);

                int result = (int)command.ExecuteScalar();
                LoginWindow.idDepart = Convert.ToInt32(result);
                connection.Close();
            }
        }

        public static int LoginAndPasswordCheck(string login,string password)
        {
            using (var connection = new SqlConnection(LoginWindow.connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password", connection);
                command.Parameters.AddWithValue("@Login", login);
                command.Parameters.AddWithValue("@Password", password);

                int count = (int)command.ExecuteScalar();
                if (count == 0)
                {
                    throw new Exception("Пользователь не найден");
                }
                else
                {
                    return count;
                }
            }
        }
        ///////
        //Методы для окна OrderBasketWindow
        public static void OrderDeyailsUpdate(int idOrder, int idMedicine, int quantity) 
        {
            using(SqlConnection connection = new SqlConnection(LoginWindow.connectionString))
                        {
                connection.Open();
                string query = "UPDATE OrderDeyails SET Quantity = @Quantity WHERE IdOrder = @IdOrder AND IdMedicine = @IdMedicine";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IdOrder", idOrder);
                command.Parameters.AddWithValue("@IdMedicine", idMedicine);
                command.Parameters.AddWithValue("@Quantity", quantity);
                command.ExecuteNonQuery();
            }
        }
        ///////
        //Методы для страницы OrderPage
        public static int FindIdOrder (int idOrder)
        {
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
                return idOrder;
            }
        }
    }
}
