using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List<int> oluşturuluyor ve içerisine birkaç tamsayı ekleniyor
        List<int> sayilar = new List<int> { 5, 10, 20, 30 };

        // Sayıların toplamı
        int toplam = 0;

        // foreach döngüsü ile liste elemanları yazdırılıyor
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);  // Sayıyı ekrana yazdır
            toplam += sayi;           // Sayıyı toplam üzerine ekle
        }

        // Sayıların toplamı ekrana yazdırılıyor
        Console.WriteLine("Toplam: " + toplam);
    }
}
