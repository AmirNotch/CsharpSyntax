using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        /*static int x = 0;
        static object locker = new object();*/

        /*static void Main(string[] args)
        {
            // 1 пример
            *//*Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start();
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Первый поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }
            Console.ReadLine();*//*

            // 2 пример
            *//*for (int i = 0; i < 5; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = "Поток " + i.ToString();
                myThread.Start();
            }

            Console.ReadLine();*/


            /*int number = 4;
            // создаём новый поток 
            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(number);

            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine("Главный поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(300);
            }

            Console.ReadLine();*//*


            // 3 пример 
            *//*Counter counter = new Counter();

            counter.x = 4;
            counter.y = 5;

            Thread myThread = new Thread(new ParameterizedThreadStart(Count));
            myThread.Start(counter);*//*


            Counter counter = new Counter(5, 4);
            Thread myThread = new Thread(new ThreadStart(counter.Count));
            myThread.Start();
        }*/

        public static void Count(object obj)
        {
            // 1 пример
            /*for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * i);
                Thread.Sleep(400);
            }*/

            // 2 пример
            /*lock (locker)
            {
                x = 1;
                for (int i = 1; i < 9; i++)
                {
                    Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, x);
                    x++;
                    Thread.Sleep(100);
                }
            }*/

            // 3 пример
            /*for (int i = 1; i < 9; i++)
            {
                Counter c = (Counter)obj;
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * c.x * c.y);
            }*/
        }
    }

    public class Counter
    {
        private int x;
        private int y;

        public Counter(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }
        public void Count()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Второй поток:");
                Console.WriteLine(i * x * y);
                Thread.Sleep(400);
            }
        }
    }
}