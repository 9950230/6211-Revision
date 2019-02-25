using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneThousandRandomFourDigitNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*********** Random Numbers **********");

            Random random = new Random();
            int[] randomNumbers = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                randomNumbers[i] = random.Next(1000, 10000);
            }

            int x = 1;
            foreach (int randomNumber in randomNumbers)
            {
                Console.Write(randomNumber + " ");
                
                if(x == 7)
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
