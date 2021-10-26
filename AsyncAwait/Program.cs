using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Program
    {
        

        static async void FactorialAsync(int n)
        {
            try
            {
                await Task.Run(() => Factorial(n)); ;
            }
            catch (Exception ex)
            {
                await Task.Run(() => Console.WriteLine(ex.Message));
            }
            finally
            {
                await Task.Run(() => Console.WriteLine("await в блоке finally"));
            }
        }

        /*static async void DoMultipleAsync()
        {
            Task allTask = null;
            try
            {
                Task t1 = Task.Run(() => Factorial(-4));
                Task t2 = Task.Run(() => Factorial(3));
                Task t3 = Task.Run(() => Factorial(-10));

                allTask = Task.WhenAll(new[] { t1, t2, t3 });
                await allTask;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Исключение: " + ex.Message);
                Console.WriteLine("IsFaulted: " + allTask.IsFaulted);
                foreach (var inx in allTask.Exception.InnerExceptions)
                {
                    Console.WriteLine("Внутренее Исключение: " + inx.Message);
                }
            }

        }*/

        static void Factorial(int n)
        {
            if (n < 1) throw new Exception($"{n} число не может быть меньше 1");
            int result = 1;
            for (int i = 0; i <= n; i++) result *= n;
            Console.WriteLine($"Факториал числа {n} равен {result}");
        }

        /*static async Task Main(string[] args)
        {
            await foreach (var number in GetNumbersAsync())
            {
                Console.WriteLine(number);
            }
        }
        public static async IAsyncEnumerable<int> GetNumbersAsync()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(100);
                yield return i;
            }
        }*/
        static async Task Main(string[] args)
        {
            Repository repo = new Repository();
            IAsyncEnumerable<string> data = repo.GetDataAsync();
            await foreach (var name in data)
            {
                Console.WriteLine(name);
            }
        }
    }

    class Repository
    {
        string[] data = { "Tom", "Sam", "Kate", "Alice", "Bob" };
        public async IAsyncEnumerable<string> GetDataAsync()
        {
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine($"Получаем {i + 1} элемент");
                await Task.Delay(500);
                yield return data[i];
            }
        }
    }

    /*public interface IAsyncEnumerable<out T>
    {
        IAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default);
    }

    public interface IAsyncEnumerator<out T> : IAsyncDisposable
    {
        T Current { get; }
        ValueTask<bool> MoveNextAsync();
    }

    public interface IAsyncDisposable
    {
        ValueTask DisposeAsync();
    }*/
}
