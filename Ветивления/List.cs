using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ветивления
{
    class List
    {
        static void Main(string[] args)
        {
            /*string text = "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ " +
               "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой " +
               "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть " +
               "если особенно упорно подойдешь к делу " +
               "будет Трудно конечнО " +
               "Код ведЬ не из простых " +
               "очень ХОРОШИЙ код " +
               "то у тебя все получится " +
               "и я буДу Писать тЕбЕ еще " +
               "чао";

            string[] lines = text.Split(' ');
            Console.WriteLine(lines.Length);
            Console.WriteLine(DecodeMessage(lines));*/

            string[] array = new[] { "A", "AB", "B", "A", "B", "B" };

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach(var e in array)
            {
                if (!dictionary.ContainsKey(e)) dictionary[e] = 0;
                dictionary[e]++;
            }

            foreach (var e in dictionary)
            {
                Console.WriteLine(e.Key + "\t" + e.Value);
            }

        }
        public static string DecodeMessage(string[] lines)
        {
            string text = "решИла нЕ Упрощать и зашифРОВАтЬ Все послаНИЕ " +
               "дАже не Старайся нИЧЕГО у тЕбя нЕ получится с расшифРОВкой " +
               "Сдавайся НЕ твоего ума Ты не споСОбЕн Но может быть " +
               "если особенно упорно подойдешь к делу " +
               "будет Трудно конечнО " +
               "Код ведЬ не из простых " +
               "очень ХОРОШИЙ код " +
               "то у тебя все получится " +
               "и я буДу Писать тЕбЕ еще " +
               "чао";

            string[] line = text.Split(' ');
            List<string> list = new List<string>();
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i].Substring(0, 1).Any(Char.IsUpper))
                {
                    list.Add(line[i]);
                }
                else
                {
                    continue;
                }
            }
            string word = "";
            list.Reverse();

            foreach (var item in list)
            {
                word += item + " ";
            }
            return word;

            /*return string.Join(" ",
                lines[0]
                .Split("!?:;., \"\'\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries) // разделить на слова
                .Where(x => char.IsUpper(x[0])) // выбрать слова, начинающиеся с большой буквы
                .Reverse().ToArray());*/
        }
    }
}
