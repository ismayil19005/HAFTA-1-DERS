using System;
using System.Collections;

class Program
{
    static void Main()
    {
        ArrayList isimler = new ArrayList();

        // Kullanıcıdan 5 isim alınır
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Bir isim giriniz:");
            string isim = Console.ReadLine();
            isimler.Add(isim);
        }

        // İsimleri alfabetik olarak sıralama
        isimler.Sort();

        // Sıralı isimleri ekrana yazdırma
        Console.WriteLine("\nAlfabetik sıralanmış isimler:");
        foreach (string isim in isimler)
        {
            Console.WriteLine(isim);
        }
    }
}
