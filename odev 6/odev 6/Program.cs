using System;

class Program
{
    static void Main()
    {
        string islem;
        do
        {
            Console.WriteLine("Bir işlem seçin (+, -, *, /): ");
            islem = Console.ReadLine();

            if (islem == "çıkış")
                break;

            Console.WriteLine("Birinci sayıyı giriniz: ");
            double sayi1 = double.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz: ");
            double sayi2 = double.Parse(Console.ReadLine());

            switch (islem)
            {
                case "+":
                    Console.WriteLine("Sonuç: " + (sayi1 + sayi2));
                    break;
                case "-":
                    Console.WriteLine("Sonuç: " + (sayi1 - sayi2));
                    break;
                case "*":
                    Console.WriteLine("Sonuç: " + (sayi1 * sayi2));
                    break;
                case "/":
                    if (sayi2 == 0)
                    {
                        Console.WriteLine("Hata: Sıfıra bölme yapılamaz.");
                    }
                    else
                    {
                        Console.WriteLine("Sonuç: " + (sayi1 / sayi2));
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem.");
                    break;
            }

        } while (islem != "çıkış");
    }
}
