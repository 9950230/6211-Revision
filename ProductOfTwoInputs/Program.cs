using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfTwoInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(firstNumber * secondNumber);
            Console.ReadLine();

        }
    }
}
