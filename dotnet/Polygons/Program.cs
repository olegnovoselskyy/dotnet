using System;
using Polygons.Library;

namespace Polygons
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("Square", square);

            var triangle = new Triangle(10);
            DisplayPolygon("Triangle", triangle);

            Console.Read();
        }

        private static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            Console.WriteLine($"Polygon: {polygonType}");
            Console.WriteLine($"Sides - {polygon.NumberOfSides}");
            Console.WriteLine($"Side Length -  {polygon.SideLength}");
            Console.WriteLine($"Perimeter - {polygon.GetPerimeter()}");
            Console.WriteLine($"Area - {polygon.GetArea()}");
            Console.WriteLine();
        }
    }
}
