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
            Func<int, int> square = x => x * x;

            Func<int, int, int> add = (x, y) => x + y;

            Func<int, int, int> subtract = (x,y) => 
            {
                int temp = x - y;
                return temp;
            };


            Console.WriteLine(subtract(2, 1));

            Action<int> write = x => Console.WriteLine(x);

            write(square(add(3, 5)));

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
