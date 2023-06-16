using System;

namespace MCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] counts = new int[] {
                4, 4, 4, 4, 1, 4, 4, 4, 5, 4, 5, 6, 6, 6, 6,
                4, 4, 4, 2, 2, 2, 2, 2, 5, 5, 5, 5, 5, 5, 2
            };

            int maximumRepetitions;
            int templateRepetitions;
            int numberWithMaximumRepetition;

            maximumRepetitions = 0;
            templateRepetitions = 1;
            numberWithMaximumRepetition = 0;

            for (int i = 1; i < counts.Length; i++)
            {
                if (counts[i] == counts[i - 1])
                {
                    ++templateRepetitions;

                    if (templateRepetitions > maximumRepetitions)
                    {
                        maximumRepetitions = templateRepetitions;
                        numberWithMaximumRepetition = counts[i];
                    }
                }
                else
                {
                    templateRepetitions = 1;
                }
            }

            string arrayToText = string.Join(",", counts);

            Console.WriteLine($"{arrayToText} - число {numberWithMaximumRepetition} повторяется {maximumRepetitions} раз.");
        }
    }
}
