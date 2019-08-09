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

            var developers = new Employee[]
            {
                new Employee {Id = 1, Name="Dima"},
                new Employee {Id = 2, Name="Oleg"},
            };

            var sales = new List<Employee>()
            {
                new Employee {Id = 3, Name="Alex"}
            };

            Console.WriteLine(developers.Count());

            var query = developers.Where(e => e.Name.Length == 4).OrderBy(e => e.Name);

            foreach (var employee in query)
            {
                Console.WriteLine(employee.Name);
            }
        }
    }
}
