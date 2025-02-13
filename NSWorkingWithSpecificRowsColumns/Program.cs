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
            int[,] array = new int[4, 4];
            int sum = 0;
            int multiplication = 1;
            int line = 2;
            int column = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(randomMin, randomMax);
                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[line - 1, i];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                multiplication *= array[i, column - 1];
            }

            Console.WriteLine($"Сумма второй строки: {sum}");
            Console.WriteLine($"Произведение первого столбца: {multiplication}");
        }
    }
}