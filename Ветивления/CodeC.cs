using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ветивления
{
    class CodeC
    {
        /*public static void Main(string[] Args)
        {

            double[] array = new[] { 1.2, 2.2, 3.2, 6.2, 4.2, };
            int[] items = new[] { 1, 2, 1, 1 };

            *//*Double method1 = MinIndex(array);
            Console.WriteLine(method1);
            Console.WriteLine(MaxIndex(array));*//*

            Console.WriteLine(GetElementCount(items, 1));


            *//*int[] a = { 1, 2, 1, 2, 1, 7, 7 };
            int max = 0, nmax = 0;
            for (int i = 0; i < a.Length - 1; i++)
                for (int n = 0, j = i + 1; j < a.Length; j++)
                    if (a[i] == a[j])
                    {
                        Console.WriteLine("" + i + " " + n);
                        if (n > nmax)
                        {
                            nmax = n;
                            max = a[i];
                        }
                    }
            if (nmax > 0) Console.WriteLine("{0} {1}", max, nmax);*/

            /*var arr = new[] { 1, 2, 3, 4,};
            var arr2 = new[] { 3, 4 };
            Console.WriteLine(FindSubarrayStaerIndex(arr, arr2));*/

            /*Console.WriteLine(GetSuit(Suits.Wands));
            Console.WriteLine(GetSuit(Suits.Coins));
            Console.WriteLine(GetSuit(Suits.Cups));
            Console.WriteLine(GetSuit(Suits.Swords));*/


            /*int[] array2 = new int[0];
            Console.WriteLine(array2 == null);*/

            /*Console.WriteLine(CheckFirstElement(null));
            Console.WriteLine(CheckFirstElement(new int[0]));
            Console.WriteLine(CheckFirstElement(new[] { 1 }));
            Console.WriteLine(CheckFirstElement(new[] { 0 }));

            var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(GetPoweredArray(arrayToPower, 1));
            Console.WriteLine(GetPoweredArray(arrayToPower, 2));
            Console.WriteLine(GetPoweredArray(arrayToPower, 3));*//*


            int[,] twoDimensionalArray = new int[2, 3];

            twoDimensionalArray[1, 2] = 1;

            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = 10 * i + j;
                    Console.Write(twoDimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(twoDimensionalArray.Length);


            int[][] arrayInArray = new int[2][];
            Console.WriteLine(arrayInArray);

            arrayInArray[0] = new int[3];

            Console.WriteLine(arrayInArray[0].Length);
            arrayInArray[0][2] = 1;
            Console.WriteLine(arrayInArray[0]);


            int[][][] arrayList = new int[2][][];
            arrayList[0] = new int[3][];
            arrayList[0][1] = new int[4];
            arrayList[0][1][2] = 14;
            Console.WriteLine(arrayList[0][1][2]);

            int[][][] arrayListing = new int[2][][];
            arrayListing[0] = new int[3][];
            arrayListing[0][1] = new int[4];
            arrayListing[0][1][2] = 85132;
            Console.WriteLine(arrayListing[0][1][2]);

            int[] massive = new int[10];
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = i;
            }
            Console.WriteLine(massive.Length-1);

            var a = new int[] { 1, 2, 3 };
            var b = new int[] { 1, 2, 3 };
            Console.WriteLine( a == a );

            var ab = "XOX OXO OXO".Replace(" ", Environment.NewLine);
            var field = ab.Split(' ');
            Console.WriteLine(field);





        }*/

        public static int[] GetPoweredArray(int[] arr, int power)
        {
            int[] array = new int[arr.Length];
            int number = 0;
            foreach (var index in arr)
            {
                
                array[number] = (int)Math.Pow(index, power);
                Console.Write(array[number] + " ");
                number++;
            }

            /*for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(array[i] = (int)Math.Pow(arr[i], power));
                Console.Write(" ");
            }*/
            return array;
        }

        public static bool CheckFirstElement(int[] array)
        {

            /*if (array == null)
                return false;
            else if (array.Length != 0)
                return false;
            else
                return true;*/
            return array != null && array.Length != 0 && array[0] == 0;
        }

        enum Suits
        {
            Wands,
            Coins,
            Cups,
            Swords
        }
        private static string GetSuit(Suits suit)
        {
            /* if (suit == Suits.Wands) return "жезлов";
             else if (suit == Suits.Coins) return "монет";
             else if (suit == Suits.Cups) return "кубков";
             else return "мечей";*/

            //return (suit == Suits.Wands) ? "жезлов" : suit == Suits.Coins ? "монет" : suit == Suits.Cups ? "кубков" : "мечей";

            return new[] { "жезлов", "монет", "кубков", "мечей", }[(int)suit];
        }


        public static int FindSubarrayStaerIndex(int[] array, int[] subarray)
        {
            for (int i = 0; i < array.Length - subarray.Length + 1; i++)
            {
                if (ConstainsAtIndex(array, subarray, i))
                {
                    return i;
                }
            }
            return -1;
        }

        public static bool ConstainsAtIndex(int[] array, int[] subarray, int index)
        {
            /*for (int j = 0; j < subarray.Length; j++)
            {
                if (array[index + j] != subarray[j]) 
                {
                    return false;
                }
            }
            return true;*/

            foreach (var item in subarray)
            {
                if (array[index] != item)
                    return false;
                else index++;
            }
            return true;
        }

        public static int GetElementCount(int[] items, int itemToCount)
        {

            var result = 0;
            foreach (var v in items)
            {
                if (v == itemToCount)
                    result++;
            }
            return result;

            /*int count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if (true)
                    {

                    } 
                    if (items[j] == items[i])
                    {
                        count++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return count;*/
        }

        public static int MinIndex(double[] array)
        {
            var min = double.MaxValue;
            int minNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minNumber = i;
                }
            }
            return minNumber;
        }

        public static int MaxIndex(double[] array)
        {
            if (array.Length == 0) return -1;

            var max = double.MinValue;
            int maxNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxNumber = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max && maxNumber != i)
                {

                }
            }
            return maxNumber;
        }
    }
}
