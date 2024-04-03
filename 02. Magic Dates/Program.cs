using System;

namespace _02.Magic_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());

            DateTime currentDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 12, 31);

            int dateWeight;

            bool found = false;

            while (currentDate.Year <= endYear)
            {
                int d1 = currentDate.Day / 10;
                int d2 = currentDate.Day % 10;

                int d3 = currentDate.Month / 10;
                int d4 = currentDate.Month % 10;

                int d5 = currentDate.Year / 1000;
                int d6 = (currentDate.Year / 100) % 10;
                int d7 = (currentDate.Year / 10) % 10;
                int d8 = currentDate.Year % 10;

                dateWeight =
                    d1 * (d2 + d3 + d4 + d5 + d6 + d7 + d8) +
                    d2 * (d3 + d4 + d5 + d6 + d7 + d8) +
                    d3 * (d4 + d5 + d6 + d7 + d8) +
                    d4 * (d5 + d6 + d7 + d8) +
                    d5 * (d6 + d7 + d8) +
                    d6 * (d7 + d8) +
                    d7 * d8;

                if (weight == dateWeight)
                {
                    Console.WriteLine($"{currentDate.Day:D2}-{currentDate.Month:D2}-{currentDate.Year}");
                    found = true;
                }

                currentDate = currentDate.AddDays(1);
            }

            if (!found)
            {
                Console.WriteLine("No");
            }

            
        }
    }
}
