using System;

namespace Ветивления
{
    /*public static class While
    {
        static void Main(string[] args)
        {
            int number = 1;
            while (number < 100)
            {
                number *= 2;
                Console.WriteLine(number);
            }

            int sum = 0;
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "") break;
                if (line.Length > 100) continue;
                sum += Convert.ToInt32(line);
            }
        }
    }*/


    //Вложенные циклы и обученные double break;
    public static class WhileInWhile
    {
        /*static void Main(string[] args)
        {
            *//*var sum = 0;
            while (true)
            {
                bool stop = false;
                while (true)
                {
                    sum += int.Parse(Console.ReadLine());
                    if (sum > 100)
                    {
                        stop = true;
                        break;
                    }
                }
                if (stop)
                {
                    break;
                }
            }*/

            /*Console.WriteLine(GetMinPowerOfTwoLargerThan(2)); // => 4
            Console.WriteLine(GetMinPowerOfTwoLargerThan(15)); // => 16
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-2)); // => 1
            Console.WriteLine(GetMinPowerOfTwoLargerThan(-100));
            Console.WriteLine(GetMinPowerOfTwoLargerThan(100));*/



            /*Console.WriteLine(RemoveStartSpaces("a"));
            Console.WriteLine(RemoveStartSpaces(" b"));
            Console.WriteLine(RemoveStartSpaces(" cd"));
            Console.WriteLine(RemoveStartSpaces(" efg"));
            Console.WriteLine(RemoveStartSpaces(" text"));
            Console.WriteLine(RemoveStartSpaces(" two words"));
            Console.WriteLine(RemoveStartSpaces("  two spaces"));
            Console.WriteLine(RemoveStartSpaces("	tabs"));
            Console.WriteLine(RemoveStartSpaces("		two	tabs"));
            Console.WriteLine(RemoveStartSpaces("                             many spaces"));
            Console.WriteLine(RemoveStartSpaces("               "));
            Console.WriteLine(RemoveStartSpaces("\n\r line breaks are spaces too"));*/


            /*WriteTextWithBorder("Menu:");
            WriteTextWithBorder("");
            WriteTextWithBorder(" ");
            WriteTextWithBorder("Game Over!");
            WriteTextWithBorder("Select level:");
            WriteTextWithBorder("Hello world");*/

            /*int sum = 0;
            while (sum < 100)
            {
                sum += int.Parse(Console.ReadLine());
            }

            sum = 0;
            for (; sum < 100;)
            {
                sum += int.Parse(Console.ReadLine());
            }*/


            /*WriteBoard(20);
            WriteBoard(19);
            WriteBoard(18);
            WriteBoard(17);
            WriteBoard(16);*//*


            int[] array = new int[3];

            array[0] = 1;
            array[1] = 3;
            array[2] = 4;

            //Console.WriteLine(array.Length);

            int[] array2 = new int[10];
            array2[0] = 2;
            array2[2] = 1;
            array2[4] = 2;
            array2[5] = 3;

            //Console.WriteLine(array2.Length);

            var arrayLenght = new[] { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine(arrayLenght.Length);

            *//*foreach (var index in array2)
            {
               // Console.WriteLine(index);
            }*//*
            for (int i = 0; i < arrayLenght.Length; i++)
            {
               // Console.WriteLine(arrayLenght[i]);
            }

            Console.WriteLine(String.Join(" ",GetFirstEvenNumbers(5)));

            *//*Console.WriteLine(string.Join(" ", display()));*//*


            double[] number = new[] { 1.0, 2.0, 3.0 };

            Console.WriteLine(Max(number));

            var value = double.MinValue;
            Console.WriteLine(value);
        }*/


        public static int[] display(int num)
        {
            int[] arr = new int[num];

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 4;
            arr[3] = 5;
            arr[4] = 5;
            return arr;
        }
        static double Max(double[] array)
        {
            var max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 0) return -1;
                if (array[i] > max) max = i;
                if (array[i] == max) return max;
            }
            return Convert.ToInt32(max);

            /*var max = double.MinValue;
            int maxInd = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxInd = i;
                }
            }

            return maxInd;*/

            /*var result = array.Length == 0 ? -1 : 0;
            for (int i = 1; i < array.Length; i++)
                result = array[result] < array[i] ? i : result;
            return result;*/
        }
        public static int[] GetFirstEvenNumbers(int count)
        {
            int[] array = new int[count];
            for (int i = 0, j = 1; i < array.Length; i++, j++)
            {
                array[i] = 2 * j;
            }
            return array;


            /*if (count < 1) return null;
            int[] tempArray = new int[count];

            for (int i = 1; i <= count; i++)
            { 
                Console.Write(tempArray[i - 1] = i * 2);
                Console.Write(" ");
            }

            return tempArray;*/
        }

        private static void WriteBoard(int size)
        {
            /*String Sharp = "";
            for (int i = 0; size <= size / 2; i++)
            {
                i
                Console.WriteLine("#.#.#.#.");
                Console.WriteLine(".#.#.#.#");

            }
            Console.WriteLine("#.#.#.#.");
            Console.WriteLine(".#.#.#.#");
            Console.WriteLine("#.#.#.#.");
            Console.WriteLine(".#.#.#.#");
            Console.WriteLine("#.#.#.#.");
            Console.WriteLine(".#.#.#.#");
            Console.WriteLine("#.#.#.#.");
            Console.WriteLine(".#.#.#.#");
            Console.WriteLine();*/

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    if (i % 2 != 0) 
                    {
                        Console.Write(j % 2 != 0 ? "#" : ".");
                    }
                    else
                    {
                        Console.Write(j % 2 != 0 ? "." : "#");
                    }
                }
                Console.WriteLine();
            }
        }



        /*public static int GetMinPowerOfTwoLargerThan(int number)
        {
            *//*if (number < 0) return 1;
            if (number == 0) number++;
            int result = 1;
            int maxVar = 1073741824;
            while( (result <= number) && (result != maxVar))
            {
                result *= 2;
            }
            if (result < number) return 1;
            return result;*/

        /*int result = 1;
        while (result <= number)
        {
            result *= 2;
        }
        return result;*//*
    }*/


        static string ReverseString(string s)
        {
            // Convert to char array, then call Array.Reverse.
            // ... Finally use string constructor on array.
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        private static void WriteTextWithBorder(string text)
        {
            String corners = "+-";
            String windows = "";
            for (int i = 1; i <= text.Length; i++)
            {
                String tire = "-";
                windows += tire;
            }
            Console.WriteLine(corners + windows + ReverseString(corners));
            Console.WriteLine($"| {text} |");
            Console.WriteLine(corners + windows + ReverseString(corners));

            /*Console.WriteLine(String.Format("{0}{1}{2}", corners, windows, ReverseString(corners)));
            Console.WriteLine($"| {text} |");
            Console.WriteLine(String.Format("{0}{1}{2}", corners, windows, ReverseString(corners)));*/


            

        }

        /*public static string RemoveStartSpaces(string text)
        {
            
            *//*return text.Trim();*/

        /*if (text == null)
        {
            return null;
        }
        if (string.IsNullOrWhiteSpace(text))
        {
            return string.Empty;
        }
        if (!char.IsWhiteSpace(text[0]))
        {
            return text;
        }

        int counter = 0;

        while (char.IsWhiteSpace(text[counter]))
        {
            counter++;
        }
        return text.Substring(counter);*//*




    }
*/

    }
}
