using System;

namespace _03.Five_Special_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int weightA = 5;
            int weightB = -12;
            int weightC = 47;
            int weightD = 7;
            int weightE = -32;

            int petBukviWeight;

            int magicPetbukviCount = 0;

            // iterate through all letter combinations
            for (char b1 = 'a'; b1 <= 'e'; b1++)
            {
                for (char b2 = 'a'; b2 <= 'e'; b2++)
                {
                    for (char b3 = 'a'; b3 <= 'e'; b3++)
                    {
                        for (char b4 = 'a'; b4 <= 'e'; b4++)
                        {
                            for (char b5 = 'a'; b5 <= 'e'; b5++)
                            {
                                // concatenate all letters
                                string petBukvi = $"{b1}{b2}{b3}{b4}{b5}";

                                // remove duplicate letters
                                string bezPovtariashtiBukvi = petBukvi;
                                for (int i = petBukvi.Length - 1; i > 0; i--)
                                {
                                    for (int j = i - 1; j >= 0; j--)
                                    {
                                        if (petBukvi[j] == petBukvi[i])
                                        {
                                            bezPovtariashtiBukvi = bezPovtariashtiBukvi.Remove(i, 1);
                                            break;
                                        }
                                    }

                                }

                                petBukviWeight = 0;
                                for (int i = 0; i < bezPovtariashtiBukvi.Length; i++)
                                {
                                    switch (bezPovtariashtiBukvi[i])
                                    {
                                        case 'a':
                                            petBukviWeight += (i + 1) * weightA;
                                            break;
                                        case 'b':
                                            petBukviWeight += (i + 1) * weightB;
                                            break;
                                        case 'c':
                                            petBukviWeight += (i + 1) * weightC;
                                            break;
                                        case 'd':
                                            petBukviWeight += (i + 1) * weightD;
                                            break;
                                        case 'e':
                                            petBukviWeight += (i + 1) * weightE;
                                            break;
                                    }
                                }

                                if (petBukviWeight >= start && petBukviWeight <= end)
                                {
                                    Console.Write(petBukvi + " ");

                                    magicPetbukviCount++;
                                }
                            }
                        }
                    }
                }
            }

            if (magicPetbukviCount == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
