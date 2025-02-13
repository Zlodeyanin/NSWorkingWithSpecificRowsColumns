using System;

namespace NSWorkingWithSpecificRowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomMin = 1;
            int randomMax = 10;
            int[,] numbers = new int[4, 4];
            int sum = 0;
            int multiplication = 1;
            int lineNumber = 2;
            int columnNumber = 1;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(randomMin, randomMax);
                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < numbers.GetLength(1); i++)
            {
                sum += numbers[lineNumber - 1, i];
            }

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                multiplication *= numbers[i, columnNumber - 1];
            }

            Console.WriteLine($"Сумма {lineNumber} строки: {sum}");
            Console.WriteLine($"Произведение {columnNumber} столбца: {multiplication}");
        }
    }
}