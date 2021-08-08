using Microsoft.EntityFrameworkCore;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(_employees);
            modelBuilder.Entity<Department>().HasData(_departments);
            base.OnModelCreating(modelBuilder);
        }



        private static List<Department> _departments = new()
        {
            new Department { Id = 1, Name = "IT", Location = "Genk" },
            new Department { Id = 2, Name = "HR", Location = "Tongeren" },
            new Department { Id = 3, Name = "Production", Location = "Hasselt" }
        };

        private static List<Employee> _employees = new()
        {
            //dept-1
            new Employee { Id = 1, FirstName = "John&", LastName = "Winter", DateOfBirth = new DateTime(2003, 01, 02), Description = "Description of John", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },
            new Employee { Id = 2, FirstName = "Sam", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Sam", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },
            new Employee { Id = 3, FirstName = "Ceyn", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 1 },
            new Employee { Id = 4, FirstName = "Donald", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },

            //dept-2
            new Employee { Id = 5, FirstName = "Tom", LastName = "Zomer", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Tom", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            new Employee { Id = 6, FirstName = "Hans", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Hans", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            new Employee { Id = 7, FirstName = "Mark", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 2 },
            new Employee { Id = 8, FirstName = "Roni", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            //dept-3
            new Employee { Id = 9, FirstName = "Arya", LastName = "Zomer", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Tom", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            new Employee { Id = 10, FirstName = "Natalie", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Hans", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            new Employee { Id = 11, FirstName = "Patricia", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 3 },
            new Employee { Id = 12, FirstName = "Silvia", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            //dept-1
            new Employee { Id = 14, FirstName = "John&", LastName = "Winter", DateOfBirth = new DateTime(2003, 01, 02), Description = "Description of John", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },
            new Employee { Id = 15, FirstName = "Sam", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Sam", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },
            new Employee { Id = 16, FirstName = "Ceyn", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 1 },
            new Employee { Id = 17, FirstName = "Donald", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 1 },

            //dept-2
            new Employee { Id = 18, FirstName = "Tom", LastName = "Zomer", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Tom", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            new Employee { Id = 19, FirstName = "Hans", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Hans", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            new Employee { Id = 20, FirstName = "Mark", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 2 },
            new Employee { Id = 21, FirstName = "Roni", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 2 },
            //dept-3
            new Employee { Id = 22, FirstName = "Arya", LastName = "Zomer", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Tom", Email = "John@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            new Employee { Id = 23, FirstName = "Natalie", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Hans", Email = "Sam@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
            new Employee { Id = 24, FirstName = "Patricia", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Ceyn", Email = "Ceyn@test.com", Gender = Gender.Female, IsMarried = true, DepartmentId = 3 },
            new Employee { Id = 25, FirstName = "Silvia", LastName = "Winter", DateOfBirth = new DateTime(2004, 01, 01), Description = "Description of Donald", Email = "Donald@test.com", Gender = Gender.Male, IsMarried = false, DepartmentId = 3 },
        };

    }
}
