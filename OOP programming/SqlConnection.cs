/*using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_programming
{
    class SqlConnections
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data source = .\DEV; Initial Catalog = ProductDB; Integrated Security = True";
            string sqlExpression = "Insert into " +
                "Products (ProductName, ManuFacturer, ProductCount, Price) " +
                "Values ('Huawei pro', 'Huawei', 10, 500.00)";

            *//*using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                Console.WriteLine("Добавлено объектов: {0}", number);
            }
            Console.Read();*/

            /*string sqlUpdateQuery = "Update Products Set ProductName = 'Lenovo p1000', Manufacturer = 'Lenovo', ProductCount = 20, Price = 1100.00 Where Id = 1002";
            using (SqlConnection updateConnection = new SqlConnection(connectionString))
            {
                updateConnection.Open();
                SqlCommand updateCommand = new SqlCommand(sqlUpdateQuery, updateConnection);
                int updateNumber = updateCommand.ExecuteNonQuery();
                Console.WriteLine("Обновленно объектов: {0}", updateNumber);
            }*//*

            string sqlDeleteQuery = "Delete From Products Where Id = 1003";
            using (SqlConnection deleteConnection = new SqlConnection(connectionString))
            {
                deleteConnection.Open();
                SqlCommand deleteCommand = new SqlCommand(sqlDeleteQuery, deleteConnection);
                int deleteNumber = deleteCommand.ExecuteNonQuery();
                Console.WriteLine("Удалено объектов: {0}", deleteNumber);
            }

            string sqlQuery = "Select * from Products";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            *//*SqlCommand command = new SqlCommand(sqlQuery, sqlConnection);*//*

            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = sqlQuery;

            SqlDataReader sqlReader = sqlCommand.ExecuteReader();

            while (sqlReader.Read())
            {
                Console.WriteLine($"ID: {sqlReader.GetValue(0)}, \t ProductName: {sqlReader.GetValue(1)}, \t" +
                    $"Manufacturer: {sqlReader.GetValue(2)}, \t ProductCount: {sqlReader.GetValue(3)}, \t" +
                    $"Price: {sqlReader.GetValue(4)}");
            }
            sqlReader.Close();
            sqlConnection.Close(); 



        }
    }
}
*/