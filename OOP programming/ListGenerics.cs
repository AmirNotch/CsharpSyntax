using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_programming
{
    class ListGenerics
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { -1, 0, 1, 2, 3, 4, 5 };

            numbers.Add(6);

            numbers.Insert(1, 666);

            numbers.RemoveAt(3);

            foreach (var item in numbers)
            {
                Console.Write(item + " \t");
            }

            Console.WriteLine();
            List<Persons> people = new List<Persons>(3)
            {
                new Persons() { Name = "Tom" },
                new Persons() { Name = "Bill" },
                new Persons() { Name = "Bill" }
            };

            /*people.Add(new Persons() { Name = "Tom" });
            people.Add(new Persons() { Name = "Bill" });
            people.Add(new Persons() { Name = "Bill" });*/

            foreach (var item in people)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadLine();
        }
    }

    class Persons
    {
        public string Name { get; set; }
    }
}
