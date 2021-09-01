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


            Console.WriteLine("Введите номер ключа pro или exp \nЕсли Хотите воспользоваться беслатной версией просто нажмите на Enter");
            string key = Console.ReadLine();
            DocumentWorker document = null;

            switch (key)
            {
                case "pro":
                    document = new ProDocumentWorker();
                    break;
                case "exp":
                    document = new ExpertDocumentWorker();
                    break;
                case "":
                    document = new DocumentWorker();
                    break;
                default:
                    break;
            }

            if (key == "pro")
            {
                document.EditDocument();
                document.SaveDocument();
            }
            else if (key == "exp")
            {
                document.SaveDocument();
            }
            else
            {
                document.OpenDocument();
                document.EditDocument();
                document.SaveDocument();
            }
        }
    }

    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        } 
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        } 
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        } 
    }

    class ProDocumentWorker : DocumentWorker
    {
        /*public override void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }*/
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }

    class ExpertDocumentWorker : ProDocumentWorker
    {
        /*public override void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }*/
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
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