using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlConnectionProj
{
    class SQLTransTesting
    {
        static void Main()
        {
            var conString = @"data Source = .\Dev; Initial catalog = AcademySummer; Integrated Security = true";

            while (true)
            {
                Console.WriteLine("1. Create client\n2. Create Account\n3. Client list\n4. Transfer from acc to acc\nChoice:");
                int.TryParse(Console.ReadLine(), out var choice);

                switch (choice)
                {
                    case 1:
                        {
                            CreateClient(conString);
                        }
                        break;
                    case 2:

                        break;
                    case 3:
                        {
                            ListClient(conString);
                        }
                        break;
                    case 4:
                        {
                            Console.Write("From acc");
                            var fromAcc = Console.ReadLine();

                            Console.Write("To acc");
                            var toAcc = Console.ReadLine();

                            decimal.TryParse(Console.ReadLine(), out var amount);
                            TransferFromToAcc(fromAcc, toAcc, amount, conString);
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        break;
                }
            }
        }

        private static void TransferFromToAcc(string fromAcc, string toAcc, decimal amount, string conString)
        {
            if (string.IsNullOrEmpty(fromAcc) || string.IsNullOrEmpty(toAcc) || amount == 0)
            {
                Console.WriteLine("SomeThing went wrong!!!");
                return;
            }

            var connection = new SqlConnection(conString);
            connection.Open();

            SqlTransaction sqlTransaction = connection.BeginTransaction();

            var command = connection.CreateCommand();

            command.Transaction = sqlTransaction;

            try
            {
                command.CommandText = "select sum(case when t.Type = 'C' then t.Amount * -1 else t.Amount end) from Transactions t " +
                    "left join Account a on t.Account_Id = a.Id where a.Number = @fromAcc";
                command.Parameters.AddWithValue(@"fromAcc", fromAcc);
                var reader = command.ExecuteReader();
                var fromBalanceAcc = 0m;

                while (reader.Read())
                {
                    fromBalanceAcc = !string.IsNullOrEmpty(reader.GetValue(0)?.ToString()) ? reader.GetDecimal(0) : 0;
                }

                reader.Close();
                command.Parameters.Clear();

                if (fromBalanceAcc <= 0 || (fromBalanceAcc - amount) < 0)
                {
                    throw new Exception("From account balance not enough amount");
                }

                var fromAccId = GetAccointId(fromAcc, conString);

                if (fromAccId == 0)
                {
                    throw new Exception("Account not found");
                }

                command.CommandText = "Insert into Transactions(Amount, Type, Created_At, Account_Id) Values(@amount, 'C', @createdAt, @accountId)";
                command.Parameters.AddWithValue(@"amount", amount);
                command.Parameters.AddWithValue(@"createdAt", DateTime.Now);
                command.Parameters.AddWithValue(@"accountId", fromAccId);

                var result1 = command.ExecuteNonQuery();

                var toAccId = GetAccointId(toAcc, conString);

                if (toAccId == 0)
                {
                    throw new Exception("Account not found");
                }

                command.Parameters.Clear();

                command.CommandText = "Insert into Transactions(Amount, Type, Created_At, Account_Id) Values(@amount, 'D', @createdAt, @accountId)";
                command.Parameters.AddWithValue(@"amount", amount);
                command.Parameters.AddWithValue(@"createdAt", DateTime.Now);
                command.Parameters.AddWithValue(@"accountId", toAccId);

                var result2 = command.ExecuteNonQuery();

                if (result1 == 0 || result2 == 0)
                {
                    throw new Exception("Something went wrong!!!");
                }

                sqlTransaction.Commit();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                sqlTransaction.Rollback();
            }
            finally
            {
                connection.Close();
            }
        }
        private static int GetAccointId(string number, string conString)
        {
            var accNumber = 0;
            var sqlConnection = new SqlConnection(conString);
            var query = "Select Id from Account where Number = @number";

            var command = sqlConnection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue(@"number", number);

            sqlConnection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                accNumber = reader.GetInt32(0);
            }

            sqlConnection.Close();
            reader.Close();

            return accNumber;
        }
        private static void CreateClient(string conString)
        {
            var client = new Client
            {
                FirstName = "tesing1",
                LastName = "testingov1",
                MiddleName = "",
                CreatedAt = DateTime.Now
            };

            var sqlConnection = new SqlConnection(conString);
            var query = "Insert into Clients(LastName, FirstName, MiddleName, Created_At) Values(@lastName, @firstName, @middleName, @createdAt)";

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = query;
            command.Parameters.AddWithValue(@"lastName", client.LastName);
            command.Parameters.AddWithValue(@"firstName", client.FirstName);
            command.Parameters.AddWithValue(@"middleName", client.MiddleName);
            command.Parameters.AddWithValue(@"createdAt", client.CreatedAt);

            sqlConnection.Open();

            var result1 = command.ExecuteNonQuery();

            if (result1 > 0)
            {
                Console.WriteLine("Added successfully");
            }

            sqlConnection.Close();
        }
        private static void ListClient(string conString)
        {
            Client[] clients = new Client[0];

            var sqlConnection = new SqlConnection(conString);
            var query = "Select Id, LastName, FirstName, MiddleName, Created_At, Updated_At from Clients";

            SqlCommand command = sqlConnection.CreateCommand();
            command.CommandText = query;

            sqlConnection.Open();

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client { };

                client.Id = int.Parse(reader["Id"].ToString());
                client.LastName = reader["LastName"].ToString();
                client.FirstName = reader["FirstName"].ToString();
                client.MiddleName = reader["MiddleName"].ToString();
                //var x = reader["Created_At"]?.ToString();
                client.CreatedAt = !string.IsNullOrEmpty(reader["Created_At"]?.ToString()) ? DateTime.Parse(reader["Created_At"].ToString()) : null;
                client.UpdatedAt = !string.IsNullOrEmpty(reader["Updated_At"]?.ToString()) ? DateTime.Parse(reader["Updated_At"].ToString()) : null;
                AddClient(ref clients, client);
            }
            sqlConnection.Close();
            foreach (var client in clients)
            {
                Console.WriteLine($"ID:{client.Id}, LastName:{client.LastName}, FirstName:{client.FirstName}, " +
                    $"MiddleName:{client.MiddleName}, CreatedAt:{client.CreatedAt}, UpdatedAt:{client.UpdatedAt}");
            }

        }
        private static void AddClient(ref Client[] clients, Client client)
        {
            if (clients == null)
            {
                return;
            }

            Array.Resize(ref clients, clients.Length + 1);

            clients[clients.Length + 1] = client;
        }
    }
    class Client
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
    class Transaction
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Type { get; set; }
        public DateTime CreatedAt { get; set; }
        public int AccountId { get; set; }
    }
    class Account
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int ClientId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}

