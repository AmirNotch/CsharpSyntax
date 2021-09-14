using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLConnection
{
    class Transaction
    {
        static void Main()
        {
            string conString = @"Data source= .\Dev; Initial Catalog = ProductDB; Integrated Security = True";

            using (SqlConnection connection = new SqlConnection(conString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;


                try
                {
                    // Выполняем две отдельные команды
                    //command.CommandText = "Insert into Products() Values";
                    /*command.CommandText = "Insert into " +
                    "Products(ProductName, Manufacturer, ProductCount, Price) " +
                    "Values('Sony xm4', 'Sony', 5, 400.00)";*/

                    command.CommandText = "Delete Products where Id = 1013";
                    command.ExecuteNonQuery();

                    /*command.CommandText = "Insert Into " +
                        "Products(ProductName, Manufacturer, ProductCount, Price) " +
                        "Values('Sony xm4', 'Sony', 5, 400.00)";*/
                    command.CommandText = "Delete Products where Id = 1012";
                    command.ExecuteNonQuery();


                    // Подтверждаем транзакцию
                    transaction.Commit();
                    Console.WriteLine("Данные добавлены в базу данных");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    transaction.Rollback();
                }
            }
        }
    }
}
