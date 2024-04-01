using System;
using System.Collections.Generic;

namespace _01.Crossing_sequences_time_optimize_try
{
    class Program
    {
        static void Main(string[] args)
        {
            int tribonacciFirst = int.Parse(Console.ReadLine());
            int tribonacciSecond = int.Parse(Console.ReadLine());
            int tribonacciThird = int.Parse(Console.ReadLine());

            int spiralFirst = int.Parse(Console.ReadLine());
            int spiralStep = int.Parse(Console.ReadLine());

            var tribonacciNumbers = new List<int>()
            {
                tribonacciFirst,
                tribonacciSecond,
                tribonacciThird
            };

            var tribonacciCurrent = tribonacciThird;

            while (tribonacciCurrent < 1000000)
            {
                tribonacciCurrent = tribonacciFirst + tribonacciSecond + tribonacciThird;

                tribonacciNumbers.Add(tribonacciCurrent);

                tribonacciFirst = tribonacciSecond;
                tribonacciSecond = tribonacciThird;
                tribonacciThird = tribonacciCurrent;
            }


            var spiralCurrent = spiralFirst;

            var spiralNumbers = new List<int>() { spiralCurrent };
            var spiralCount = 0;
            var spiralStepMul = 1;

            while (spiralCurrent < 1000000)
            {
                spiralCurrent += spiralStep * spiralStepMul;

                spiralNumbers.Add(spiralCurrent);
                spiralCount++;

                if (spiralCount % 2 == 0)
                {
                    spiralStepMul++;
                }
            }


            var found = false;

            for (int i = 0; i < tribonacciNumbers.Count; i++)
            {
                Console.WriteLine(tribonacciNumbers[i]);
                for (int j = 0; j < spiralNumbers.Count; j++)
                {
                    Console.WriteLine(spiralNumbers[j]);
                    if (tribonacciNumbers[i] == spiralNumbers[j] &&
                        tribonacciNumbers[i] <= 1000000)
                    {
                        Console.WriteLine(tribonacciNumbers[i]);
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}
