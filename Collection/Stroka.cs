using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Stroka
    {
        /*static void Main(string[] args)
        {
            string stroka = "Hello world";
            string strokaB = "Hello world";
            Console.WriteLine(stroka.Substring(0, 5));
            Console.WriteLine(stroka.ToLower());

            Console.WriteLine(stroka[0]);
            Console.WriteLine(stroka.Equals(strokaB));
            double d = Math.Log(2, 10) * 100;
            Console.WriteLine(Math.Round(d, 2));

            string tallestBuildings = "Burj Khalifa 830 " +
                "Petronius(oil platform) 640" +
                "Tokyo Skytree 634" +
                "KVLY - TV mast 629" +
                "Canton Tower 604" +
                "Abraj Al Bait Towers 601" +
                "Bullwinkle(oil platform) 529" +
                "Troll A platform 472" +
                "Lualualei VLF transmitter 458" +
                "Petronas Twin Towers 452" +
                "Willis Tower 442" +
                "Ekibastuz GRES-Two Power Station 420" +
                "Dimona Radar Facility 400" +
                "Kiev TV Tower 385" +
                "Zhoushan Island Overhead Powerline Tie 370" +
                "Gerbrandy Tower 367" +
                "TV Tower Vinnytsia 354" +
                "Millau Viaduct 342" +
                "Amazon Tall Tower Observatory 325" +
                "Lakihegy Tower 314"; 

            Console.WriteLine(GetBenfordStatistics("1"));
            Console.WriteLine(GetBenfordStatistics("abc"));
            Console.WriteLine(GetBenfordStatistics("123 456 789"));
            Console.WriteLine(GetBenfordStatistics("abc 123 def 456 gf 789 i"));
            Console.WriteLine(GetBenfordStatistics(tallestBuildings));
        }*/
        public static int[] GetBenfordStatistics(string text)
        {
            /*var statistics = new int[10];
            double d = 0.0;
            int numberElement = 0;
            for (int i = 0; i < text.Length; i++)
            {
                *//*if (statistics[i] == 10)
                    break;*//*
                if (Char.IsDigit(text[i]))
                {
                    d = Math.Log(1 + (1 / (i + 1)), 10) * 100;
                    statistics[numberElement] = Convert.ToInt32(d);
                    numberElement++;
                }
                else
                {
                    continue;
                }
                
            }
            foreach (var item in statistics)
            {
                if (item == 0)
                {
                    break;
                }
                Console.WriteLine(item);
            }
            return statistics;*/

            var statistics = new int[10];
            string[] line = text.Split(' ');
            foreach (var word in line)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsDigit(word[i]))
                    {
                        statistics[word[i] - '0']++;
                        break;
                    }
                }
            }
            foreach (var item in statistics)
            {
                Console.Write(item + ",");
            }
            return statistics;
        }
    }
}
