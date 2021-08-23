using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class OverloadMethods
    {
        static void Main(string[] args)
        {
            var x = "0000";
            Console.WriteLine(x);
            ChangeRef(ref x);
            Console.WriteLine(x);
            ChangeOut(out var y);
            Console.WriteLine(y);

            var z = "dawd";
            Console.WriteLine(z);

            ChangeIn(z);
            Console.WriteLine(y);

            Add(2.0, 2.0);
            Add(2, 2);

            Int64[] array = new Int64[] { 1, 2, 3, 4 };
            var arrString = new string[] { "one", "two", "three", "four" };
            WriteArray(array);
            WriteArray(arrString);
            WriteArray("2","2","5","6");

            var arr = new int[10];

            arr[8] = 19;
            arr[9] = 5;
            Console.WriteLine(arr[arr.Length - 2]);
            
        }
        public static void ChangeRef(ref string x)
        {
            x = "55";
        }
        public static void ChangeOut(out string y)
        {
            y = "da";
        }
        public static void ChangeIn(in string z)
        {
            string text = z;
            text = " ";
        }
        public static int Add(int x, int y)
        {
            Console.WriteLine("Calling method with int param");
            Console.WriteLine(x + y);
            return x + y;
        }
        /// <summary>
        /// Method Add double
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static double Add(double x, double y)
        {
            Console.WriteLine("Calling method with double param");
            Console.WriteLine(x + y);
            return x + y;
        }

        public static void WriteArray(params string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
        public static void WriteArray(Int64[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]}\t");
            }
            Console.WriteLine();
        }
    }
    static class ArrayHelperStatic
    {
        public static int Age { get; set; }
    }
    class ArrayHelper
    {
        public static int Age { get; set; }
    }
}
