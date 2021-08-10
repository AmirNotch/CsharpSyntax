using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        /*static void Main(string[] args)
        {
            var array = new[] { "A", "AB", "B", "A", "B", "B" };

            var dictionary = new Dictionary<string, int>();

            foreach (var e in array)
            {
                if (!dictionary.ContainsKey(e)) dictionary[e] = 0;
                dictionary[e]++;
            }

            foreach (var e in dictionary)
            {
                Console.WriteLine(e.Key + "\t" + e.Value);
            }

            List<string> contacts = new List<string>();
            contacts.Add("Ваня:v@mail.ru");
            contacts.Add("Вася:vasiliy@gmail.com");
            contacts.Add("Ваня:ivan@grozniy.ru");
            contacts.Add("Саша:sasha1995@sasha.ru");
            contacts.Add("Саша:alex@nd.ru");
            contacts.Add("Паша:pavel.egorov@urfu.ru");
            contacts.Add("Юрий:dolg@rukiy.ru");
            contacts.Add("Гена:genadiy.the.best@inbox.ru");

            var dict = OptimizedContacts(contacts);
            Console.WriteLine(dict);
        }*/

        private static List<string> GetContacts()
        {
            List<string> contacts = new List<string>();
            contacts.Add("Ваня:v@mail.ru");
            contacts.Add("Вася:vasiliy@gmail.com");
            contacts.Add("Ваня:ivan@grozniy.ru");
            contacts.Add("Саша:sasha1995@sasha.ru");
            contacts.Add("Саша:alex@nd.ru");
            contacts.Add("Паша:pavel.egorov@urfu.ru");
            contacts.Add("Юрий:dolg@rukiy.ru");
            contacts.Add("Гена:genadiy.the.best@inbox.ru");
            return contacts;
        }

        private static Dictionary<string, List<string>> OptimizedContacts(List<string> contacts)
        {
            var dictionary = new Dictionary<string, List<string>>();

            foreach (var contact in contacts)
            {
                var name = contact.Split(':')[0];
                var namePrefix = (name.Length <= 2) ? name : name.Substring(0, 2);

                if (dictionary.ContainsKey(namePrefix))
                {
                    dictionary[namePrefix].Add(contact);
                    Console.WriteLine(dictionary[namePrefix]);
                }
                else
                {
                    dictionary[namePrefix] = new List<string>() { contact };
                }
            }

            return dictionary;
        }
    }
}