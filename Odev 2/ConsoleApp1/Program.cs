using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan bir cümle alınır
        Console.WriteLine("Bir cümle giriniz:");
        string cumle = Console.ReadLine();

        // Cümledeki kelimeler Split metodu ile ayrılır
        string[] kelimeler = cumle.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        // Kelime sayısı hesaplanır
        int kelimeSayisi = kelimeler.Length;

        // Kelime sayısı ekrana yazdırılır
        Console.WriteLine("Cümledeki kelime sayısı: " + kelimeSayisi);
    }
}
