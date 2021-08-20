using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class ClassProperties
    {
       /* static void Main()
        {
            Person instance1 = new Person()
            {
                CanDrive = false,
                Status = false,
                YearOfBirthday = 2000
            };

            Person instance2 = new Person()
            {
                CanDrive = false,
                Status = true,
                YearOfBirthday = 1980
            };

            instance1.WriteAge();
            instance2.WriteAge();

            Console.WriteLine(instance1.GetAge());

        }*/
    }

    class Person
    {
        public int YearOfBirthday { get; init; }

        public int Name { get; set; }

        public bool Status { get; set; }

        public bool CanDrive { get; set; }

        public Person()
        {

        }

        public int GetAge()
        {
            var currentYear = DateTime.Now.Year;
            return currentYear = YearOfBirthday;
        }

        public void WriteAge()
        {
            var currentPesonAge = GetAge();
            Console.WriteLine($"Year of birth current person is {currentPesonAge}");
        }
        public void WriteInfo(string instanceName)
        {
            Console.WriteLine($"Instance: {instanceName}, Name: {Name}, Age: {0}, Year of birth: {YearOfBirthday}");

            Console.ResetColor();
        }

        public Person(int age, string name)
        {
            /*Name = name;*/
        }
    }
}
