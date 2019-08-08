using System;
using System.Collections.Generic;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] developers = new Employee[]
            {
                new Employee {Id = 1, Name="Dima"},
                new Employee {Id = 1, Name="Dima"},
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name="Alex"}
            };

            Console.WriteLine(developers.Count());
        }
    }
}
