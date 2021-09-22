using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_programming
{
    class Generics
    {
        /*static void Main()
        {
            Account<int> account1 = new Account<int>
            {
                Sum = 5000
            };

            Account<string> account2 = new Account<string>
            {
                Sum = 4000
            };

            Account<int>.session = 4567;
            Account<String>.session = "45243";

            account1.Id = 2;
            account2.Id = "4567";

            int id1 = account1.Id;
            string id2 = account2.Id;

            *//*Console.WriteLine(id1);
            Console.WriteLine(id2);

            Console.WriteLine(Account<int>.session);
            Console.WriteLine(Account<String>.session);*/

            /*Account<int> acc1 = new Account<int> { Id = 1857, Sum = 4500 };
            Account<int> acc2 = new Account<int> { Id = 3245, Sum = 5000 };

            Transaction<Account<int>, string> transaction1 = new Transaction<Account<int>, string>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Code = "4535677655",
                Sum = 900
            };*//*


            int x = 7;
            int y = 25;
            Swap<Int32>(ref x, ref y);
            Console.WriteLine($"X = {x}, Y = {y}");

            string s1 = "hello";
            string s2 = "world";
            Swap<String>(ref s1, ref s2);
            Console.WriteLine($"S1 = {s1}, S2 = {s2}");

            Account acc1 = new Account(1854) { Sum = 4566 };
            Account acc2 = new Account(3453) { Sum = 5000 };
            Transactions<Account> transactions = new Transactions<Account>
            {
                FromAccount = acc1,
                ToAccount = acc2, 
                Sum = 6900
            };
            transactions.Execute();

            Console.ReadLine();


        }*/

        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

    }

    class Transactions<T> where T : Account
    {
        public T FromAccount { get; set; }
        public T ToAccount { get; set; }
        public int Sum { get; set; }

        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счёт {FromAccount.Id}: {FromAccount.Sum}$ \nСчёт {ToAccount.Id}: {ToAccount.Sum}$");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
            }
        }
    }

    class Account
    {
        public int Id { get; private set; } // номер счета
        public int Sum { get; set; }
        public Account(int _id)
        {
            Id = _id;
        }
    }

    class Transaction<U, V>
    {
        public U FromAccount { get; set; }
        public U ToAccount { get; set; }
        public V Code { get; set; }
        public int Sum { get; set; }
    }
    class Account<T>
    {
        public static T session;
        public T Id { get; set; }
        public int Sum { get; set; }
    }
}
