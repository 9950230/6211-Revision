using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace ArrayContainsVsManuallyCheckingForUniqueNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // The method using .Contains() checks every element while the other method only checks the elements we have set
            // max is exclusive and min is inclusive
            int min = 0;
            int max = 10000;
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int[] randomUniqueNumbers = RandomUniqueNumbers(min, max);
            sw.Stop();
            Console.WriteLine("Time to Process RandomUniqueNumbers: " + sw.ElapsedMilliseconds + " Milliseconds\n");

            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            int[] randomUniqueNumbersManualCheck = RandomUniqueNumbersManualCheck(min, max);
            sw2.Stop();
            Console.WriteLine("Time to Process RandomUniqueNumbersManualCheck: " + sw2.ElapsedMilliseconds + " Milliseconds\n");

            //WriteNumbers(randomUniqueNumbersManualCheck);
            //WriteNumbers(randomUniqueNumbers);

            Console.ReadLine();

        }

        public static void WriteNumbers(int[] randomNumbers)
        {

            Console.WriteLine("*********** Random Numbers **********");

            int x = 1;
            foreach (int randomNumber in randomNumbers)
            {
                Console.Write(randomNumber + " ");

                if (x == 9)
                {
                    x = 0;
                    Console.Write("\n");
                }

                x++;
            }

            Console.Write("\n\n");

        }

        public static int[] RandomUniqueNumbers(int min, int max, int arrayLength = -1)
        {

            if (arrayLength > (max - min) || arrayLength < 0)
                arrayLength = max - min;

            int[] randomNumbers = new int[arrayLength];
            Thread.Sleep(20); // Change the seed
            Random random = new Random();
            int uniqueNumberCount = 0;
            int numberToCheck;

            while (uniqueNumberCount < arrayLength && uniqueNumberCount <= (max - min))
            {
                // maxValue is exclusive and minValue is inclusive
                numberToCheck = random.Next(min, max + 1);

                if (randomNumbers.Contains(numberToCheck))
                    continue;

                randomNumbers[uniqueNumberCount] = numberToCheck;
                uniqueNumberCount++;
            }

            return randomNumbers;

        }

        // No array helper methods
        public static int[] RandomUniqueNumbersManualCheck(int min, int max, int arrayLength = -1)
        {

            if (arrayLength > (max - min) || arrayLength < 0)
                arrayLength = max - min;

            int[] randomNumbers = new int[arrayLength];
            Thread.Sleep(20); // Change the seed
            Random random = new Random();
            int uniqueNumberCount = 0;
            int numberToCheck;

            while (uniqueNumberCount < arrayLength && uniqueNumberCount <= (max - min))
            {

                // maxValue is exclusive and minValue is inclusive
                numberToCheck = random.Next(min, max + 1);

                for (int i = 0; i <= uniqueNumberCount; i++)
                {
                    if (numberToCheck == randomNumbers[i])
                        continue;
                }

                randomNumbers[uniqueNumberCount] = numberToCheck;
                uniqueNumberCount++;
            }

            return randomNumbers;

        }
    }
}
