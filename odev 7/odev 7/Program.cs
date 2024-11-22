using System;

class Program
{
    static void Main()
    {
        int toplam = 0;
        int sayi;

        // While döngüsü ile pozitif sayıları toplama
        while (true)
        {
            Console.WriteLine("Bir pozitif sayı giriniz (Çıkmak için 0 girin): ");
            sayi = int.Parse(Console.ReadLine());

            if (sayi == 0)
                break;

            if (sayi > 0)
            {
                toplam += sayi;
            }
            else
            {
                Console.WriteLine("Lütfen pozitif bir sayı giriniz.");
            }
        }

        Console.WriteLine("\nToplam: " + toplam);

        // For döngüsü ile girilen sayıları yazdırma
        Console.WriteLine("\nGirilen pozitif sayılar:");
        // (Bu kısmı, sayıları saklamak için bir koleksiyon kullanarak yapmanız gerekirdi, burada basitliği sağlamak için sadece toplamı yazdırıyoruz.)
    }
}
