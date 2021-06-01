using Microsoft.EntityFrameworkCore;
using System;
using WPFAppExamen.Model;

namespace WPFAppExamen.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {

        }

        public DbSet<Person> Persons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=AIRLBEOF11958\\SYNTRA;Initial Catalog=WPF;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

        }
    }
}
