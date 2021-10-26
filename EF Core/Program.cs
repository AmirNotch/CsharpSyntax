using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace EF_Core
{
    class Program
    {
        static async Task Main(string[] args)
        {

            // Добавление
            /*using (var applicationContext = new ApplicationContext())
            {
                *//*var clients = await applicationContext.Clients.ToListAsync();*//*

                Client user1 = new Client() { LastName = "Nikita", FirstName = "Nikitov", MiddleName = " ", Created_At = DateTime.Now };

                applicationContext.Add(user1);
                await applicationContext.SaveChangesAsync();
            }*/


            // получение
            /*using (var applicationContext = new ApplicationContext())
            {
                var clients = await applicationContext.Clients.ToListAsync();
                Console.WriteLine("Данные получены");

                foreach (Client item in clients)
                {
                    Console.WriteLine($"{item.Id}, {item.LastName}, {item.FirstName}, {item.MiddleName}, {item.Created_At}, {item.Updated_At}");
                }
            }*/


            // Редактирование
            /*using (var applicationContext = new ApplicationContext())
            {
                
                Client client = await applicationContext.Clients.FindAsync(5);
                if (client != null)
                {
                    client.FirstName = "Aziz";
                    client.LastName = "Azizov";
                    client.MiddleName = "Azizovich";
                    client.Updated_At = DateTime.Now;

                    applicationContext.Update(client);
                    await applicationContext.SaveChangesAsync();
                }

                var clients = await applicationContext.Clients.ToListAsync();
                foreach (Client item in clients)
                {
                    Console.WriteLine($"{item.Id}, {item.LastName}, {item.FirstName}, {item.MiddleName}, {item.Created_At}, {item.Updated_At}");
                }
            }*/

            // Удаление
            using (var applicationContext = new ApplicationContext())
            {
                
                Client client = await applicationContext.Clients.FindAsync(5);
                if (client != null)
                {
                    applicationContext.Remove(client);
                    await applicationContext.SaveChangesAsync();
                }

                var clients = await applicationContext.Clients.ToListAsync();
                foreach (Client item in clients)
                {
                    Console.WriteLine($"{item.Id}, {item.LastName}, {item.FirstName}, {item.MiddleName}, {item.Created_At}, {item.Updated_At}");
                }
            }
        }
    }
}
