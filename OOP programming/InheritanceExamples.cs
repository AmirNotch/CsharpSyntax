using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_programming
{
    class InheritanceExamples
    {
        /*static void Main()
        {
            Employee tom = new Employee(name: "Tom", age: 23, company: "Microsoft");
            
        }*/
    }

    class Person 
    {
        string name;
        int age;

        public Person(string name)
        {
            this.name = name;
            Console.WriteLine("Person(string name)");
        }

        public Person(string name, int age) : this(name)
        {
            this.age = age;
            Console.WriteLine("Person(string name, int age)");
        }
    }
    /*class Employee : Person
    {
        string company;

        public Employee(string name, int age, string company) : base(name, age)
        {
            this.company = company;
            Console.WriteLine("Employee(string name, int age, string company)");
        }
    }*/
}
