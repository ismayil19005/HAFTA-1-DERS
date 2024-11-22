using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bir sayı giriniz:");
        int n = int.Parse(Console.ReadLine());

        int a = 0, b = 1, c;

        Console.Write("Fibonacci Serisi: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            c = a + b;
            a = b;
            b = c;
        }
    }
}
