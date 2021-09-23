using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_programming
{
    class HomeLesson
    {
        static void Main()
        {


            Dictionary<string, ModelsLaptop<String, decimal>> laptops = new Dictionary<string, ModelsLaptop<string, decimal>>();

            laptops.Add("Bad", new ModelsLaptop<string, decimal> { Mark = "Lenovo", Price = 500.00m });
            laptops.Add("Nice", new ModelsLaptop<string, decimal> { Mark = "MacBook", Price = 1000.00m });
            laptops.Add("Normal", new ModelsLaptop<string, decimal> { Mark = "Dell", Price = 800.00m });
            laptops.Add("Normal", new ModelsLaptop<string, decimal> { Mark = "HP-Omen", Price = 700.00m });

            bool working = true;
            while (working)
            {
                Console.WriteLine("1.Exit\n2.Добавить Ноутбук\n3.Выберать Ноутбук по счёту\n4.Transfer From One Account To Another Account\nChoice:");
                int.TryParse(Console.ReadLine(), out var choice);
                switch (choice)
                {
                    case 1:
                        working = false; 
                        break;
                    case 2:
                        Console.Write("Качество");
                        var kachestvo = Console.ReadLine();
                        Console.Write("Модель ноута");
                        var model = Console.ReadLine();
                        Console.Write("Цена");
                        Decimal.TryParse(Console.ReadLine(), out var price);
                        laptops.Add(kachestvo, new ModelsLaptop<string, decimal> { Mark = model, Price = price});
                        break;
                    case 3:
                        foreach (KeyValuePair<string, ModelsLaptop<string, decimal>> item in laptops)
                        {
                            Console.WriteLine($"Модель: {item.Value.Mark} - Качество: {item.Key} - Цена: {item.Value.Price}");
                        }

                        break;
                    case 4:
                        break;

                    default:
                        break;
                }
            }
        }
    }

    public class ModelsLaptop<T, U>
    {
        public T Mark { get; set; }
        public U Price { get; set; }
    }
}
