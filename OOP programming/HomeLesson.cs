﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OOP_programming
{
    class HomeLesson
    {
/*        static void Main()
        {

            *//*var serialNumber = Console.ReadLine();
            var errorSerialNumber1 = Regex.IsMatch(serialNumber, "^(([A-Z]){1})[0-9]{8}$");
            Console.WriteLine(errorSerialNumber1);
            if (errorSerialNumber1)
            {
                Console.WriteLine("Bad");
            }
            if (errorSerialNumber1)
            {
                Console.WriteLine("Good");
            }*//*
            var currentTime = DateTime.Now;
            TimeSpan now = DateTime.Now.TimeOfDay;
            Console.WriteLine(now);


            *//*int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
*/
            /*int.TryParse(Console.ReadLine(), out var salary);
            if (salary is int)
            {
                Console.WriteLine(salary);
            }
            if (salary == 0)
            {
                Console.WriteLine("hello");
            }
            Console.WriteLine();*/
            /*salary:
                        Console.Write("Укажите свою заработную плату\nНапример: 3000\n");
                        decimal.TryParse(Console.ReadLine(), out var salary);
                        if (salary <= 0)
                        {
                            Console.Write("Укажите свою заработную плату\nВыше чем 0\n");
                            goto salary;
                        }
                        else if (salary == 0)
                        {
                            Console.Write("Укажите свою заработную плату\nНапример: 3000\n");
                            goto salary;
                        }
            credit:
                        Console.Write("Укажите сумму кредита которую вы хотите взять\nНапример: 1000\n");
                        decimal.TryParse(Console.ReadLine(), out var credit);
                        if (credit <= 0)
                        {
                            Console.Write("Укажите сумму кредита которую вы хотите взять\nВыше чем 0\n");
                            goto credit;
                        }
                        else if (credit == 0)
                        {
                            Console.Write("Укажите сумму кредита которую вы хотите взять\nНапример: 1000\n");
                            goto credit;
                        }
                        decimal salaryCount = ((credit / salary) * 100.00m);
                        Console.WriteLine(salaryCount);*//*



            var nowdate = DateTime.Now;
            Console.WriteLine(nowdate);
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine(nowdate.AddMonths(i));
            }
            *//*// 1 Задача
            List<SmartPhones<string, decimal>> smartPhones = new List<SmartPhones<string, decimal>>();

            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = "Nice", Model = "Samsung", Price = 1000m });
            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = "Nice", Model = "Iphone", Price = 1000m });
            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = "Normal", Model = "Xiaomi", Price = 950m });
            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = "Normal", Model = "Huawei", Price = 700m });

            bool working = true;
            while (working)
            {
                Console.WriteLine("1.Выйти\n2.Добавить Телефон\n3.Выберать Телефон по индексу\n4.Посчитать общее количество Телефонов\nВыбор:");
                int.TryParse(Console.ReadLine(), out var choice);
                switch (choice)
                {
                    case 1:
                        working = false;
                        break;
                    case 2:
                        {
                            Console.Write("Качество: ");
                            var kachestvo = Console.ReadLine();
                            Console.Write("Модель телефона: ");
                            var model = Console.ReadLine();
                            Console.Write("Цена: ");
                            Decimal.TryParse(Console.ReadLine(), out var price);
                            smartPhones.Add(new SmartPhones<string, decimal> { Kachestvo = kachestvo, Model = model, Price = price });
                        }
                        break;
                    case 3:
                        {
                            foreach (SmartPhones<string, decimal> items in smartPhones)
                            {
                                Console.WriteLine($"Модель: {items.Model} - Качество: {items.Kachestvo} - Цена: {items.Price}");
                            }
                            Console.Write("Выберите Модель Телефона :");

                            var model = Console.ReadLine();
                            *//*Console.WriteLine(laptops[model].Price);*//*
                            Console.WriteLine();

                            var number = 0;
                            foreach (SmartPhones<string, decimal> items in smartPhones)
                            {
                                if (items.Model == model)
                                {
                                    Console.WriteLine($"Модель: {items.Model} - Качество: {items.Kachestvo} - Цена: {items.Price}");
                                    Console.WriteLine($"Индекс: Элемента {++number}");
                                }
                                number++;
                            }
                        }
                        break;
                    case 4:
                        {
                            var number = 0;
                            for (int i = 0; i < smartPhones.Count; i++)
                            {
                                if (i == smartPhones.Count - 1)
                                {
                                    Console.WriteLine($"Всего {++number} Телефонов");
                                }
                                number++;
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Something went wrong!!!");
                        break;
                }
            }


            // 2 Задача
            Dictionary<string, ModelsLaptop<String, decimal>> laptops = new Dictionary<string, ModelsLaptop<string, decimal>>();

            laptops.Add("Lenovo", new ModelsLaptop<string, decimal> { Kachestvo = "Bad", Price = 500.00m });
            laptops.Add("MacBook", new ModelsLaptop<string, decimal> { Kachestvo = "Nice", Price = 1000.00m });
            laptops.Add("Dell", new ModelsLaptop<string, decimal> { Kachestvo = "Normal", Price = 800.00m });
            laptops.Add("HP-Omen", new ModelsLaptop<string, decimal> { Kachestvo = "Normal", Price = 700.00m });

            working = true;
            while (working)
            {
                Console.WriteLine("1.Выйти\n2.Добавить Ноутбук\n3.Выберать Ноутбук по индексу\n4.Посчитать общее количество Ноутбук\nВыбор:");
                int.TryParse(Console.ReadLine(), out var choice);
                switch (choice)
                {
                    case 1:
                        working = false;
                        break;
                    case 2:
                        {
                            Console.Write("Качество: ");
                            var kachestvo = Console.ReadLine();
                            Console.Write("Модель ноута: ");
                            var model = Console.ReadLine();
                            Console.Write("Цена: ");
                            Decimal.TryParse(Console.ReadLine(), out var price);
                            laptops.Add(model, new ModelsLaptop<string, decimal> { Kachestvo = kachestvo, Price = price });
                        }
                        break;
                    case 3:
                        {
                            foreach (KeyValuePair<string, ModelsLaptop<string, decimal>> item in laptops)
                            {
                                Console.WriteLine($"Модель: {item.Key} - Качество: {item.Value.Kachestvo} - Цена: {item.Value.Price}");
                            }
                            Console.Write("Выберите Модель Ноутбука :");
                            var model = Console.ReadLine();
                            *//*Console.WriteLine(laptops[model].Price);*//*
                            Console.WriteLine();
                            Console.WriteLine($"Модель: {model} - Качество: {laptops[model].Kachestvo} - Цена: {laptops[model].Price}");
                        }
                        break;
                    case 4:
                        var number = 0;
                        for (int i = 0; i < laptops.Count; i++)
                        {
                            if (i == laptops.Count - 1)
                            {
                                Console.WriteLine($"Всего {++number} Ноутбук");
                            }
                            number++;
                        }
                        break;
                    default:
                        Console.WriteLine("Something went wrong!!!");
                        break;
                }
            }*//*
        }
*/    }

    public class ModelsLaptop<T, U>
    {
        public T Kachestvo { get; set; }
        public U Price { get; set; }
    }

    public class SmartPhones<T, Z>
    {
        public T Kachestvo { get; set; }
        public T Model { get; set; }
        public Z Price { get; set; }
    }
}
