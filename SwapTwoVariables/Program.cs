using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo = 20;

            Console.WriteLine("A = " + valueOne + "  B = " + valueTwo);
            int temp = valueOne;
            valueOne = valueTwo;
            valueTwo = temp;

            Console.WriteLine("A = " + valueOne + "  B = " + valueTwo);
            Console.ReadLine();
        }
    }
}
