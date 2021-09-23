using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_programming
{
    class DictionaryGenerics
    {
       /* static void Main()
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(5);

            countries.Add(1, "Tajikistan");
            countries.Add(2, "Kazakhstan");
            countries.Add(3, "Uzbekistan");
            countries.Add(4, "Russia");
            countries.Add(5, "USA");

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            string country = countries[4];

            Console.WriteLine(country);
            countries[4] = "Ukrain";
            Console.WriteLine(countries[4]);
            countries.Remove(2);

            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            Dictionary<char, Persons> people = new Dictionary<char, Persons>();
            people.Add('b', new Persons() { Name = "Bill" });
            people.Add('t', new Persons() { Name = "Tom" });
            people.Add('j', new Persons() { Name = "John" });

            people['d'] = new Persons() { Name = "David" };

            foreach (KeyValuePair<char, Persons> keyValue in people)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value.Name);
            }

            foreach (char letter in people.Keys)
            {
                Console.WriteLine(letter);
            }

            foreach (Persons name in people.Values)
            {
                Console.WriteLine(name.Name);
            }

            Dictionary<string, string> count = new Dictionary<string, string>
            {
                ["France"] = "Paris"
            };

            foreach (KeyValuePair<string, string> keyValue in count)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
        }*/
    }
}
