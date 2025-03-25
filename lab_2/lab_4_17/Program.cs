using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків (n): ");
        int n = int.Parse(Console.ReadLine());
        
        int[][] jaggedArray = new int[n][];
        
        // Заповнення східчастого масиву
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
            int m = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[m];
            
            Console.WriteLine($"Введіть {m} елементів рядка {i + 1}:");
            for (int j = 0; j < m; j++)
            {
                jaggedArray[i][j] = int.Parse(Console.ReadLine());
            }
        }
        
        // Підрахунок кількості додатних елементів у кожному рядку
        int[] positiveCounts = new int[n];
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            foreach (int num in jaggedArray[i])
            {
                if (num > 0) count++;
            }
            positiveCounts[i] = count;
        }
        
        Console.WriteLine("Кількість додатних елементів у кожному рядку:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Рядок {i + 1}: {positiveCounts[i]}");
        }
        
        // Двовимірний масив
        int maxColumns = 0;
        foreach (var row in jaggedArray)
        {
            if (row.Length > maxColumns) maxColumns = row.Length;
        }
        
        int[,] twoDArray = new int[n, maxColumns];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                twoDArray[i, j] = jaggedArray[i][j];
            }
        }
        
        // Підрахунок для двовимірного масиву
        int[] positiveCounts2D = new int[n];
        for (int i = 0; i < n; i++)
        {
            int count = 0;
            for (int j = 0; j < maxColumns; j++)
            {
                if (twoDArray[i, j] > 0) count++;
            }
            positiveCounts2D[i] = count;
        }
        
        Console.WriteLine("Кількість додатних елементів (двовимірний масив):");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Рядок {i + 1}: {positiveCounts2D[i]}");
        }
    }
}
