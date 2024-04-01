using System;

namespace _01.Crossing_sequences_without_arrays_try
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


            var tribonacciCurrent = tribonacciFirst;

            var spiralCurrent = spiralFirst;

            var spiralCount = 0;
            var spiralStepMul = 1;

            while (tribonacciCurrent <= 1000000 && spiralCurrent <= 1000000)
            {
                if (tribonacciCurrent == spiralCurrent)
                {
                    Console.WriteLine(tribonacciCurrent);
                    return;
                }
                else if (tribonacciCurrent < spiralCurrent)
                {

                    if (tribonacciCurrent == tribonacciFirst)
                    {
                        tribonacciCurrent = tribonacciSecond;
                    }
                    else if (tribonacciCurrent == tribonacciSecond)
                    {
                        tribonacciCurrent = tribonacciThird;
                    }
                    else
                    {
                        tribonacciCurrent = tribonacciFirst + tribonacciSecond + tribonacciThird;

                        tribonacciFirst = tribonacciSecond;
                        tribonacciSecond = tribonacciThird;
                        tribonacciThird = tribonacciCurrent;
                    }
                }
                else  // tribonacciCurrent > spiralCurrent
                {
                    spiralCurrent += spiralStep * spiralStepMul;

                    spiralCount++;

                    if (spiralCount % 2 == 0)
                    {
                        spiralStepMul++;
                    }
                }
            }

            Console.WriteLine("No");
        }
    }
}
