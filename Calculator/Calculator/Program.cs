using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1. sayıyı giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2. sayıyı giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İşlem seçiniz (1: Toplama, 2: Çıkarma, 3: Çarpma, 4: Bölme): ");
            int islem = Convert.ToInt32(Console.ReadLine());

            if (islem == 1)
            {
                Topla(sayi1, sayi2);
            }
            else if (islem == 2)
            {
                Cikart(sayi1, sayi2);
            }
            else if (islem == 3)
            {
                Carpma(sayi1, sayi2);
            }
            else if (islem == 4)
            {
                Bolme(sayi1, sayi2);
            }
            else
            {
                Console.WriteLine("Geçersiz işlem numarası!");
            }
        }

        static void Topla(double sayi1, double sayi2)
        {
            Console.WriteLine("Toplama yapılıyor...");
            double sonuc = sayi1 + sayi2;
            Console.WriteLine($"Sonuç: {sonuc}");
        }

        static void Cikart(double sayi1, double sayi2)
        {
            Console.WriteLine("Çıkarma yapılıyor...");
            double sonuc = sayi1 - sayi2;
            Console.WriteLine($"Sonuç: {sonuc}");
        }

        static void Carpma(double sayi1, double sayi2)
        {
            Console.WriteLine("Çarpma yapılıyor...");
            double sonuc = sayi1 * sayi2;
            Console.WriteLine($"Sonuç: {sonuc}");
        }

        static void Bolme(double sayi1, double sayi2)
        {
            if (sayi2 == 0)
            {
                Console.WriteLine("Hata: Sıfıra bölme yapılamaz!");
                return;
            }
            Console.WriteLine("Bölme yapılıyor...");
            double sonuc = sayi1 / sayi2;
            Console.WriteLine($"Sonuç: {sonuc}");
        }
    }
}
