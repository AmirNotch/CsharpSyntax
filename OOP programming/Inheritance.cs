using System;

namespace OOP_programming
{
    class Inheritance
    {
        /*static void Main(string[] args)
        {
            Human human = new Human()
            {
                FirstName = "Karim",
                LastName = "Karimov",
                MiddleName = "Karimovich",
                YearOfBirth = 2000,
            };
            human.ShowInfo();

            Human human1 = new Human("firuza", "Firuzova", "firuzovna", 2000);
            human1.ShowInfo();

            Employee emp = new Employee
            {
                FirstName = "Firuza",
                LastName = "Firuzova",
                MiddleName = "Firuzovna",
                YearOfBirth = 1990,
                Salary = 5500
            };

            emp.ShowInfo();
            emp.ShowClearSalary();

            Employee emp1 = new Employee(6000, 13, "karim", "karimov", "kaarimocich", 2000);
            emp1.ShowInfo();
            emp1.ShowClearSalary();

            Manager m1 = new Manager()
            {
                Employers = new Employee[]
                {
                    new Employee { FirstName = "Rahim", LastName = "Rahimov", MiddleName = "Rahimovich", YearOfBirth = 2001, Salary = 3700},
                    new Employee { FirstName = "Rahim", LastName = "Rahimov", MiddleName = "Rahimovich", YearOfBirth = 2001, Salary = 1500},
                    new Employee { FirstName = "Rahim", LastName = "Rahimov", MiddleName = "Rahimovich", YearOfBirth = 2001, Salary = 2000},
                    new Employee { FirstName = "Rahim", LastName = "Rahimov", MiddleName = "Rahimovich", YearOfBirth = 2001, Salary = 4000},
                    new Employee { FirstName = "Rahim", LastName = "Rahimov", MiddleName = "Rahimovich", YearOfBirth = 2001, Salary = 5000},
                    new Employee { FirstName = "Rahim", LastName = "Rahimov", MiddleName = "Rahimovich", YearOfBirth = 2001, Salary = 6000}
                },
                FirstName = "Laylo",
                LastName = "Layloeva",
                MiddleName = "Layloevna",
                Salary = 7000,
                YearOfBirth = 2005
            };

            m1.ListOfEmployers();
        }*/
    }
    class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public int YearOfBirth { get; set; }
        public bool IsFree { get; set; } = true;


        public Human() { }

        public Human(string firstName, string lastName, string middleName, int yearOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = middleName;
            YearOfBirth = yearOfBirth;
            Console.WriteLine("Executed base constructor");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName}, MiddleName: {MiddleName}, Age: {YearOfBirth}");
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
            Console.WriteLine("Executed child constructor");
        }

        public decimal ShowClearSalary()
        {
            var result = Salary - (Salary * Tax / 100);
            Console.WriteLine($"Clear salary is {result}");
            return result;
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
                emp.ShowInfo();
                emp.ShowClearSalary();
            }
        }
    }
}
