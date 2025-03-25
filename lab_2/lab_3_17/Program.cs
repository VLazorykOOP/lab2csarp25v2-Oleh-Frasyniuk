using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність квадратного масиву (n): ");
        int n = int.Parse(Console.ReadLine());
        
        int[,] matrix = new int[n, n];
        
        Console.WriteLine("Введіть елементи двовимірного масиву:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        
        // Підрахунок суми побічної діагоналі (двовимірний масив)
        int sum2D = 0;
        for (int i = 0; i < n; i++)
        {
            sum2D += matrix[i, n - 1 - i];
        }
        Console.WriteLine($"Сума елементів побічної діагоналі (2D масив): {sum2D}");
        
        // Одновимірне представлення масиву
        int[] oneDArray = new int[n * n];
        for (int i = 0, k = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++, k++)
            {
                oneDArray[k] = matrix[i, j];
            }
        }
        
        // Підрахунок суми побічної діагоналі (одновимірний масив)
        int sum1D = 0;
        for (int i = 0; i < n; i++)
        {
            sum1D += oneDArray[i * n + (n - 1 - i)];
        }
        Console.WriteLine($"Сума елементів побічної діагоналі (1D масив): {sum1D}");
    }
}
