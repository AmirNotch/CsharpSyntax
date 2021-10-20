using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class InnerAndOuterTask
    {
        /*static void Main(string[] args)
        {
            *//*var outer = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Outer task starting...");
                var inner = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Inner task starting...");
                    Thread.Sleep(2000);
                    Console.WriteLine("Inner task finished.");
                }, TaskCreationOptions.AttachedToParent);
            });
            outer.Wait();*//*
            Console.WriteLine("End of Main");


            Task[] task1 = new Task[4]
            {
                new Task(() => Console.WriteLine("First Task")),
                new Task(() => Thread.Sleep(2000)),
                new Task(() => Console.WriteLine("Second Task")),
                new Task(() => Console.WriteLine("Third Task"))
            };

            foreach (var t in task1)
            {
                t.Start();
            }
            Task.WaitAny(task1);


            *//*Task[] task2 = new Task[3];
            int j = 1;
            for (int i = 0; i < task2.Length; i++)
            {
                task2[i] = Task.Factory.StartNew(() => Console.WriteLine($"Task {j++}"));
            }*//*
            Console.WriteLine("Завершение метода Main");
            Console.ReadLine();
        }*/
    }
}
