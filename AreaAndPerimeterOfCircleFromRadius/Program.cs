using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeterOfCircleFromRadius
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a Number: ");
            double radius = double.Parse(Console.ReadLine());

            double pi = Math.PI;

            // Perimeter = 2 * PI * r
            double circlePerimeter = 2 * pi * radius;

            // Area = PI * r^2
            double circleArea = pi * Math.Pow(radius, 2);


            Console.WriteLine("Perimeter: " + circlePerimeter);
            Console.WriteLine("Area: " + circleArea);

            Console.ReadLine();
        }
    }
}
