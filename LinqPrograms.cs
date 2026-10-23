using System;
using System.Collections.Generic;
using System.Text;

namespace DSACodingExercise
{
    public static class LinqPrograms
    {
        public static List<Employee> GetEmployees() => new List<Employee>
        {
            new Employee { Id = 1, Name = "Sumit",  Department = "IT",      Salary = 80000, City = "Pune" },
            new Employee { Id = 2, Name = "Rahul",  Department = "IT",      Salary = 95000, City = "Mumbai" },
            new Employee { Id = 3, Name = "Priya",  Department = "HR",      Salary = 60000, City = "Pune" },
            new Employee { Id = 4, Name = "Anita",  Department = "Finance", Salary = 75000, City = "Pune" },
            new Employee { Id = 5, Name = "Vikas",  Department = "IT",      Salary = 70000, City = "Delhi" },
            new Employee { Id = 6, Name = "Neha",   Department = "HR",      Salary = 65000, City = "Mumbai" },
            new Employee { Id = 7, Name = "Sumit",  Department = "Finance", Salary = 72000, City = "Pune" }
        };
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Department { get; set; } = "";
        public decimal Salary { get; set; }
        public string City { get; set; } = "";
    }
}
