/*
    class Program


{
    static void Main()
    {
        Console.WriteLine("Lütfen birinci sayıyı girin:");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lütfen ikinci sayıyı girin:");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        double fark = sayi1 - sayi2;

        Console.WriteLine($"İki sayının farkı: {fark}");
    }
}
*/
;

/*
    class Program
{
    static void Main()
    {
        int sayi = 5;
        int kare = sayi * sayi;
        Console.WriteLine($"{sayi} sayısının karesi: {kare}");
    }
}
*/


/*
 class Program
{
    static void Main()
    {
        int sayi = 10;
        int bolen = 3;

        int kalan = sayi % bolen;

        Console.WriteLine($"10 sayısının 3'e bölümünden kalan: {kalan}");
    }
}
*/


/*
 class Program
{
    static void Main()
    {
        double[] sayilar = new double[4];
        double toplam = 0;
        double carpim = 1;

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"{i + 1}. sayıyı girin:");
            sayilar[i] = Convert.ToDouble(Console.ReadLine());
            toplam += sayilar[i];
            carpim *= sayilar[i];
        }

        Console.WriteLine($"Girdiğiniz sayıların toplamı: {toplam}");
        Console.WriteLine($"Girdiğiniz sayıların çarpımı: {carpim}");
    }
}
*/
/*
 class Program
 
{
    static void Main()
    {
        Console.WriteLine("Lütfen birinci sayıyı girin:");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Lütfen ikinci sayıyı girin:");
        double sayi2 = Convert.ToDouble(Console.ReadLine());
        {
            double bolum = sayi1 / sayi2;
            Console.WriteLine($"İki sayının bölümü: {bolum}");
        }
    }
}
*/
/*class Program
{
    static void Main()
    {
        // Kullanıcıdan kenarları al
        Console.Write("Dikdörtgenler prizmasının uzun kenarını girin: ");
        double uzunKenar = Convert.ToDouble(Console.ReadLine());

        Console.Write("Dikdörtgenler prizmasının kısa kenarını girin: ");
        double kisaKenar = Convert.ToDouble(Console.ReadLine());

        Console.Write("Dikdörtgenler prizmasının yüksekliğini girin: ");
        double yukseklik = Convert.ToDouble(Console.ReadLine());

        // Hacmi hesapla
        double hacim = uzunKenar * kisaKenar * yukseklik;

        // Sonucu ekrana yazdır
        Console.WriteLine($"Dikdörtgenler prizmasının hacmi: {hacim}");
    }
}
*/