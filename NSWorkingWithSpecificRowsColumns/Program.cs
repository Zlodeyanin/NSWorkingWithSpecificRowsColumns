using System;

namespace NSWorkingWithSpecificRowsColumns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array = new int[5, 5];
            int sum = 0;
            int multiplication = 1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(1, 10);

                    if (i == 1)
                    {
                        sum += array[i, j];
                    }

                    if (j == 0)
                    {
                        multiplication *= array[i, j];
                    }

                    Console.Write(array[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Сумма второй строки: {sum}");
            Console.WriteLine($"Произведение первого столбца: {multiplication}");
        }
    }
}