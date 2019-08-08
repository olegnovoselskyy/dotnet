using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQFeatures
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] developers = new Employee[]
            {
                new Employee {EmployeeID = 1, Name = "Oleg Novo"},
                new Employee {EmployeeID = 2, Name = "Dima Lytvyn"}
            };

            List<Employee> sales = new List<Employee>()
            {
                new Employee { EmployeeID = 3, Name = "Soyn Lytvyn"}
            };

            //Console.WriteLine(sales.Count());

            //foreach (var dev in developers)
            //{
            //    Console.WriteLine(dev.Name);
            //}

            foreach (var employee in developers.Where(x => x.Name.StartsWith('O')))
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
