using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; 

namespace EF_Core
{
    class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-NP2IPR8\\DEV; Initial Catalog = AcademySummer; integrated security = True;");
        }
    }
}
