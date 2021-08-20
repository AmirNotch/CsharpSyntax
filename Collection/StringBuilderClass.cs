using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class StringBuilderClass
    {
        /*public static void Main()
        {
            var builder = new StringBuilder();

            builder.Append("Some ");
            builder.Append("string ");
            builder.Append("%15 ");
            builder.Remove(0, 5);
            builder.Insert(0, "test ");

            builder[0] = 'T';

            var str = builder.ToString();
            Console.WriteLine(str);


        }*/

        static void WrongConcatenation()
        {
            var str = "";

            for (int i = 0; i < 50000; i++)
            {
                str += i.ToString() + " ";
            }
        }
        static void RightConcatenation()
        {
            var builder = new StringBuilder();
            for (int i = 0; i < 50000; i++)
            {
                builder.Append(i);
                builder.Append(" ");
            }
        } 
       /* public static void Main()
        {
            var watch = new Stopwatch();
            watch.Start();
            WrongConcatenation();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            watch = new Stopwatch();
            watch.Start();
            RightConcatenation();
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }*/
    }
}
