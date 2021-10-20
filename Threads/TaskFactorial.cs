using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class TaskFactorial
    {
        static void Main(string[] args)
        {
            Task<int> task1 = new Task<int>(() => Factorial(5));
            task1.Start();
            Console.WriteLine($"Факториял числа 5 равен {task1.Result}");
            Task<Book> task2 = new Task<Book>(() =>
            {
                return new Book { Title = "Война и мир", Author = "Лев Т." };
            });
            task2.Start();
            Book b = task2.Result;
            Console.WriteLine($"Название книги: {b.Title}, Автор: {b.Author}");
            Console.ReadLine();
        }

        static int Factorial(int x)
        {
            int result = 1;
            for (int i = 0; i <= x; i++)
            {
                result *= i;
            }

            return result;
        }
    }

    public class Book
    {
        public String Title { get; set; }
        public string Author { get; set; }
    }
}
