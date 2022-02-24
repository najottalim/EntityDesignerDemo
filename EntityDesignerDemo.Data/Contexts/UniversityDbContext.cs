using EntityDesignerDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDesignerDemo.Data.Contexts
{
    public class UniversityDbContext: DbContext
    {
        public DbSet<Group> Groups { get; set; }
        
        public DbSet<Student> Students { get; set; }

        public DbSet<Teacher> Teachers { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=university;User Id=postgres; Password=root;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable(nameof(Student));
                //, t => t.ExcludeFromMigrations());

            base.OnModelCreating(modelBuilder);
        }
    }
}
