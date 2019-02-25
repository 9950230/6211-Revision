using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneHundredUniqueRandomThreeDigitNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Random Numbers **********");

            Random random = new Random();
            int[] randomNumbers = new int[100];
            int uniqueNumberCount = 0;
            int numberToCheck;
            
            while (uniqueNumberCount < 100)
            {

                // maxValue is exclusive and minValue is inclusive
                numberToCheck = random.Next(100, 1000);

                for (int i = 0; i <= uniqueNumberCount; i++)
                {
                    if (numberToCheck == randomNumbers[i])
                        continue;
                }

                randomNumbers[uniqueNumberCount] = numberToCheck;
                uniqueNumberCount++;
            }

            int x = 1;
            foreach (int randomNumber in randomNumbers)
            {
                Console.Write(randomNumber + " ");
                
                if(x == 9)
                {
                    x = 0;
                    Console.Write("\n");
                }

                x++;
            }

            Console.ReadLine();
        }
    }
}
