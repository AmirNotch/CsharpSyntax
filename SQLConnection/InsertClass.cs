using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SQLConnection
{
    class InsertClass
    {
        /*static void Main()
        {
            var conString = @"Data Source = .\Dev; Initial Catalog = Customers; Integrated Security = True";

            SqlConnection sqlConnection = new SqlConnection(conString);

            sqlConnection.Open();

            Console.Write("firstName: ");
            var firstName = Console.ReadLine();
            Console.Write("lastname: ");
            var lastname = Console.ReadLine();
            Console.Write("email: ");
            var email = Console.ReadLine();
            Console.Write("phone: ");
            var phone = int.Parse(Console.ReadLine());

            InsertData(sqlConnection, new Customers
            {
                FirstName = firstName,
                Lastname = lastname,
                Email = email,
                Phone = phone
            });

        }*/
        static void InsertData(SqlConnection sqlConnection, Customers customers)
        {
            var query = $"Insert Into " +
                $"Customers(FirstName, LastName, Email, Phone) " +
                $"Values('{customers.FirstName}','{customers.Lastname}','{customers.Email}',{customers.Phone})";

            SqlCommand sqlCommand = sqlConnection.CreateCommand();

            sqlCommand.CommandText = query;

            var result = sqlCommand.ExecuteNonQuery();

            if (result > 0)
            {
                Console.WriteLine("Product added successfully!!!");
            }
        }
    }
    class Customers
    {
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int CustomerId { get; set; }
        public int CreatedAt { get; set; }
    }
}
