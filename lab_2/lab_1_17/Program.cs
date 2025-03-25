using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність масиву: ");
        int n = int.Parse(Console.ReadLine());
        
        double[] array = new double[n];
        
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            array[i] = double.Parse(Console.ReadLine());
        }
        
        double product = 1;
        foreach (double num in array)
        {
            product *= num;
        }
        
        if (Math.Abs(product) >= 100 && Math.Abs(product) < 1000)
        {
            Console.WriteLine("Добуток є тризначним числом.");
        }
        else
        {
            Console.WriteLine("Добуток не є тризначним числом.");
        }
    }
}
