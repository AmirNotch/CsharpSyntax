using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_programming
{
    enum PersonType
    {
        NotSet,
        Human,
        Employee,
        Manager
    }
    class PolymotphismAcademy
    {
        static void Main()
        {



            Human h = null;

            PersonType type = PersonType.NotSet;

            Console.Write("Кого вы хотите создать?\n1. Человек 2. Сотрудник 3." +
                "Менеджер\nВыбор: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1": type = PersonType.Human; break;   
                case "2": type = PersonType.Employee; break;
                case "3": type = PersonType.Manager; break;    
            }

            switch (type)
            {
                case PersonType.Human:
                    h = new Human();
                    break;
                case PersonType.Employee:
                    h = new Employee();
                    break;
                case PersonType.Manager:
                    h = new Manager();
                    break;
                default:
                    break;
            }

            if (h == null)
            {
                Console.WriteLine("Not set");
                return;
            }
            h.Show();

        }
    }
    
    class Human
    {
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public string MiddleName { get; set; }
        public int YearOfBirth { get; set; }

        public Human() { }

        public Human(string firstName, string lastName, string middleName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            YearOfBirth = yearOfBirth;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName}, MiddleName: {MiddleName}, Age: {YearOfBirth}");
        }

        public virtual void Show()
        {
            Console.WriteLine("I'm human");
        }
    }

    class Employee : Human
    {
        public decimal Salary { get; set; }
        public decimal Tax { get; set; }

        public Employee() { }

        public Employee(decimal salary, decimal tax, string firstName, string lastName, string middleName, int yearOfBirth) 
            : base(firstName, lastName, middleName, yearOfBirth)
        {
            Salary = salary;
            Tax = tax;
        }

        public decimal ShowClearSalary(bool canShow = false)
        {
            var result = Salary - (Salary / Tax * 100);
            if (canShow) Console.WriteLine($"Clear salary is {result}");
            return result;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Salary: {Salary}, Tax:{Tax}, ClearSalary:{ShowClearSalary()}");
        }

        public override void Show()
        {
            Console.WriteLine("I'm employee");
        }
    }

    class Manager : Employee
    {
        public Employee[] Employers { get; set; }

        public void ListOfEmployers()
        {
            if (Employers == null) return;

            foreach (var emp in Employers)
            {
                Console.Write("\t --- ");
                emp.ShowInfo();
                emp.ShowClearSalary();
            }
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            ListOfEmployers();
        }

        public override void Show()
        {
            Console.WriteLine("I'm manager");
        }
    }
}