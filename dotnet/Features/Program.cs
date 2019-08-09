using System;
using System.Collections.Generic;
using System.Linq;
//using Features.Linq;

namespace Features
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] developers = new Employee[]
            {
                new Employee {Id = 1, Name="Dima"},
                new Employee {Id = 2, Name="Oleg"},
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee {Id = 3, Name="Alex"}
            };

            Console.WriteLine(developers.Count());

            foreach(var employee in developers.Where(e => e.Name.StartsWith("D")))
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
