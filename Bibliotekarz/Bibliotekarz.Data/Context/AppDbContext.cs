using Bibliotekarz.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotekarz.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connString = "Server=localhost;Database=BibliotekarzDb;Integrated Security=true;Trusted_Connection=true;TrustServerCertificate=true;MultipleActiveResultSets=true;";
            //string connString = "Server=locahost;Database=BibliotekarzDb;User Id=sa;Password=***;Trusted_Connection=true;";
            optionsBuilder.UseSqlServer(connString)
                .EnableDetailedErrors()
                .EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Customer> Borrowers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(e => e.Title).HasMaxLength(150);

            //modelBuilder.Entity<Book>().HasOne(e => e.Borrower).WithMany();


            base.OnModelCreating(modelBuilder);
        }
    }
}
