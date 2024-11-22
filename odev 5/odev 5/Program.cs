using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int sayi = random.Next(1, 101);  // 1 ile 100 arasında rastgele bir sayı
        int tahmin = 0;

        Console.WriteLine("1 ile 100 arasında bir sayı tahmin edin.");

        while (tahmin != sayi)
        {
            Console.Write("Tahmininizi girin: ");
            tahmin = int.Parse(Console.ReadLine());

            if (tahmin < sayi)
            {
                Console.WriteLine("Daha büyük bir sayı girin.");
            }
            else if (tahmin > sayi)
            {
                Console.WriteLine("Daha küçük bir sayı girin.");
            }
            else
            {
                Console.WriteLine("Tebrikler! Doğru tahmin!");
            }
        }
    }
}
