using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків (n): ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців (m): ");
        int m = int.Parse(Console.ReadLine());
        
        double[,] array = new double[n, m];
        
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                array[i, j] = double.Parse(Console.ReadLine());
            }
        }
        
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 1; j < m; j++) // Починаємо з 1, щоб мати попередній елемент
            {
                if (array[i, j] > array[i, j - 1])
                {
                    count++;
                }
            }
        }
        
        Console.WriteLine($"Кількість елементів, більших за попередній: {count}");
    }
}
