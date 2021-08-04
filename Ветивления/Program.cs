using System;

namespace Ветивления
{
    class Program
    {

        //метод обмена элементов
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортировка пузырьком
        static int[] BubbleSort(int[] array)
        {
            var len = array.Length;
            for (var i = 1; i < len; i++)
            {
                for (var j = 0; j < len - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(ref array[j], ref array[j + 1]);
                    }
                }
            }
            return array;
        }

        /*static void Main(string[] args)
        {
            *//*Console.WriteLine("Сортировка пузырьком");
            Console.Write("Введите элементы массива: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }

            Console.WriteLine("Отсортированный массив: {0}", string.Join(", ", BubbleSort(array)));

            Console.ReadLine();*//*

            var a = true;
            Console.WriteLine(ShouldFire2(true, "Zombie", 100));
            Console.WriteLine((a) ? 0 : 25);
        }*/

        static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            return enemyInFront && ((enemyName == "boss") ? ((robotHealth < 50) ? false : true) : true);
        }

        static bool ShouldFire(bool enemyInFront, string enemyName, int robotHealth)
        {
            bool shouldFire = true;
            if (enemyInFront == true)
            {
                if (enemyName == "boss")
                {
                    if (robotHealth < 50) shouldFire = false;
                    if (robotHealth > 100) shouldFire = true;
                }
            }
            else
            {
                return false;
            }
            return shouldFire;
        }
        /*public static void TestMove(string from, string to)
        {
            Console.WriteLine("{0}-{1}-{2}", from, to, IsCorrectMove(from, to));
        }
        public static bool IsCorrectMove(string from, string to)
        {
            var dx = Math.Abs(to[0] - from[0]);
            var dy = Math.Abs(to[1] - from[1]);

            return (dx == dy || dx == 0 || dy == 0) && !from.Equals(0);
        }
        static void Main(string[] args)
        {
            TestMove("a1", "d4");
            TestMove("f4", "e7");
            TestMove("a1", "a4");
            TestMove("a1", "a1");
        }*/
    }
}
