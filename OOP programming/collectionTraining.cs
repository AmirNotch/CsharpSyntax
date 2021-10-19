using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_programming
{
    class DelegateMethods
    {
        delegate void DelegateMethod(double x, double y);

        static void Main(string[] args)
        {
            DelegateMethod delegateMethod;

            delegateMethod = Sum;

            delegateMethod += Minus;

            delegateMethod -= Minus;

            delegateMethod(1, 2);

            int[] a = new int[4] { 1, 2, 3, 4 };
        }

        static void Sum(double x, double y)
        {
            Console.WriteLine("Method Sum");
            Console.WriteLine(x + y);
        }

        static void Minus(double x, double y)
        {
            Console.WriteLine("Method Minus");
            Console.WriteLine(x - y);
        }
    }
}
