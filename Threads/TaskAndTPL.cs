using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    class TaskAndTPL
    {
        /*static void Main(string[] args)
        {
            *//*Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
            task1.Start();

            Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));

            Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));

            Console.ReadLine();*/

        /*Task task = new Task(Display);
        task.Start();
        Console.WriteLine("Завершение метода Main");
        task.Wait();

        Console.WriteLine("Good Buy");
        Console.ReadLine();*//*

        Task task1 = new Task(() =>
        {
            Console.WriteLine($"Id задачи: {Task.CurrentId}");
        });
        // задача продолжения
        Task task2 = task1.ContinueWith(Display);
        task1.Start();
        // Ждём окончания второй задачи
        task2.Wait();
        Console.WriteLine("Выполняется работа метода Main");
        Console.ReadLine();
    }

    public static void Display(Task t)
    {
        *//*Console.WriteLine("Начало работы метода Display");
        Console.WriteLine("Завершение работы метода Display");*//*
        Console.WriteLine($"Id задачи: {Task.CurrentId}");
        Console.WriteLine($"Id предыдущей задачи: {t.Id}");
        Thread.Sleep(3000);
    }*/


        static void Main(string[] args)
        {
            /*Task<int> task1 = new Task<int>(() => Sum(4, 5));
            // Задача продолжения
            Task task2 = task1.ContinueWith(sum => Display(sum.Result));
            task1.Start();
            // Ждём окончания второй задачи
            task2.Wait();
            Console.WriteLine("End of Main");
            Console.ReadLine();*/

            Task task1 = new Task(() =>
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });

            // Задача продолжения
            Task task2 = task1.ContinueWith(Display);

            Task task3 = task1.ContinueWith((Task t) =>
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });
            
            Task task4 = task2.ContinueWith((Task t) =>
            {
                Console.WriteLine($"Id задачи: {Task.CurrentId}");
            });

            task1.Start();
            Console.ReadLine();
        }

        public static void Display(Task t)
        {
            Console.WriteLine($"Id Задачи: {Task.CurrentId}");
        }

        /*public static int Sum(int a, int b) => a + b;
        public static void Display(int sum)
        {
            Console.WriteLine($"Sum {sum}");
        }*/

    }
}
