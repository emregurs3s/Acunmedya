using System;
using System.Collections.Generic;

namespace CSharpEgzersizleri
{
    // Çalışan sınıfı (4. Ödev için)
    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Meslek { get; set; }
        public double Maas { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, string meslek, double maas, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Meslek = meslek;
            Maas = maas;
            Departman = departman;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Meslek: {Meslek}, Maaş: {Maas:C2}, Departman: {Departman}");
        }
    }

    // Araba sınıfı (5. Ödev için)
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public double BenzinTuketimi { get; set; } // 100 km başına litre

        public Araba(string marka, string model, int yil, double benzinTuketimi)
        {
            Marka = marka;
            Model = model;
            Yil = yil;
            BenzinTuketimi = benzinTuketimi;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Yıl: {Yil}, Benzin Tüketimi: {BenzinTuketimi} lt/100km");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bool devam = true;

            while (devam)
            {
                Console.WriteLine("\n===== C# EGZERSİZLERİ =====");
                Console.WriteLine("1. Yaş Kategorisi Belirleme");
                Console.WriteLine("2. Araba Yaşı ve Durumu");
                Console.WriteLine("3. While ve Do-While Döngüleri");
                Console.WriteLine("4. Çalışan Maaş Hesaplaması");
                Console.WriteLine("5. Arabaların Benzin Tüketimi");
                Console.WriteLine("0. Çıkış");
                Console.Write("\nLütfen bir seçenek girin: ");

                if (int.TryParse(Console.ReadLine(), out int secim))
                {
                    Console.WriteLine();
                    
                    switch (secim)
                    {
                        case 1:
                            YasKategorisiUygulamasi();
                            break;
                        case 2:
                            ArabaYasiUygulamasi();
                            break;
                        case 3:
                            WhileDoWhileOrnekleri();
                            break;
                        case 4:
                            CalisanMaasHesaplama();
                            break;
                        case 5:
                            ArabaBenzinTuketimi();
                            break;
                        case 0:
                            devam = false;
                            Console.WriteLine("Program sonlandırılıyor...");
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçenek! Lütfen tekrar deneyin.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
                }

                if (devam)
                {
                    Console.WriteLine("\nDevam etmek için bir tuşa basın...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        // 1. Ödev: Yaş Kategorisini Belirleme
        static void YasKategorisiUygulamasi()
        {
            Console.WriteLine("===== YAŞ KATEGORİSİ BELİRLEME =====");
            Console.Write("Lütfen yaşınızı girin: ");
            
            if (int.TryParse(Console.ReadLine(), out int yas))
            {
                string sonuc = YasKategorisiBelirle(yas);
                Console.WriteLine($"Sonuç: {sonuc}");
            }
            else
            {
                Console.WriteLine("Geçersiz yaş girişi!");
            }
        }

        static string YasKategorisiBelirle(int yas)
        {
            if (yas < 0 || yas > 99)
                return "Ya hiç doğmadınız ya da çoktan öldünüz...";
            else if (yas >= 0 && yas < 18)
                return "Küçüksünüz";
            else if (yas >= 18 && yas < 35)
                return "Gençsiniz";
            else if (yas >= 35 && yas < 55)
                return "Yetişkinsiniz";
            else if (yas >= 55 && yas < 75)
                return "Yaşlısınız";
            else // yas >= 75 && yas <= 99
                return "Çok yaşlısınız";
        }

        // 2. Ödev: Araba Yaşı ve Durumu
        static void ArabaYasiUygulamasi()
        {
            Console.WriteLine("===== ARABA YAŞI VE DURUMU =====");
            Console.WriteLine("1. If-Else ile hesaplama");
            Console.WriteLine("2. Switch-Case ile hesaplama");
            Console.Write("Seçiminiz (1 veya 2): ");
            
            if (int.TryParse(Console.ReadLine(), out int secim) && (secim == 1 || secim == 2))
            {
                Console.Write("Lütfen arabanın yaşını girin: ");
                
                if (int.TryParse(Console.ReadLine(), out int arabaYasi))
                {
                    string sonuc = secim == 1 
                        ? ArabaDurumuBelirleIfElse(arabaYasi) 
                        : ArabaDurumuBelirleSwitch(arabaYasi);
                    
                    Console.WriteLine($"Sonuç: {sonuc}");
                }
                else
                {
                    Console.WriteLine("Geçersiz araba yaşı girişi!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }
        }

        static string ArabaDurumuBelirleIfElse(int arabaYasi)
        {
            if (arabaYasi < 0 || arabaYasi > 30)
                return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
            else if (arabaYasi >= 0 && arabaYasi < 10)
                return "Arabanız yeni";
            else if (arabaYasi >= 10 && arabaYasi < 20)
                return "Servise götürmeniz gerekebilir";
            else // arabaYasi >= 20 && arabaYasi <= 30
                return "Arabanız hurdaya çıkabilir";
        }

        static string ArabaDurumuBelirleSwitch(int arabaYasi)
        {
            // Klasik switch-case 
            switch (arabaYasi)
            {
                case var y when y < 0 || y > 30:
                    return "Ya hiç üretilmedi ya da trafikten men edilmiştir";
                case var y when y >= 0 && y < 10:
                    return "Arabanız yeni";
                case var y when y >= 10 && y < 20:
                    return "Servise götürmeniz gerekebilir";
                case var y when y >= 20 && y <= 30:
                    return "Arabanız hurdaya çıkabilir";
                default:
                    return "Geçersiz araba yaşı";
            }
        }

        // 3. Ödev: While ve Do-While Döngüleri
        static void WhileDoWhileOrnekleri()
        {
            Console.WriteLine("===== WHILE VE DO-WHILE DÖNGÜ ÖRNEKLERİ =====");
            
            // While örneği
            Console.WriteLine("\n--- While Döngüsü Örneği ---");
            Console.WriteLine("While döngüsü, koşul doğru olduğu sürece çalışır.");
            Console.WriteLine("Koşul baştan yanlışsa hiç çalışmaz.");
            
            int sayac1 = 1;
            Console.WriteLine("\nWhile döngüsü ile 1'den 5'e kadar sayılar:");
            while (sayac1 <= 5)
            {
                Console.Write($"{sayac1} ");
                sayac1++;
            }
            
            int sayac2 = 10; // Koşul baştan yanlış
            Console.WriteLine("\n\nKoşulu baştan yanlış olan while döngüsü (hiç çalışmaz):");
            while (sayac2 < 5)
            {
                Console.Write($"{sayac2} ");
                sayac2++;
            }
            Console.WriteLine("(Döngü çalışmadı)");
            
            // Do-While örneği
            Console.WriteLine("\n--- Do-While Döngüsü Örneği ---");
            Console.WriteLine("Do-While döngüsü, önce işlemi yapar, sonra koşulu kontrol eder.");
            Console.WriteLine("Koşul yanlış bile olsa en az bir kere çalışır.");
            
            int sayac3 = 1;
            Console.WriteLine("\nDo-While döngüsü ile 1'den 5'e kadar sayılar:");
            do
            {
                Console.Write($"{sayac3} ");
                sayac3++;
            } while (sayac3 <= 5);
            
            int sayac4 = 10; // Koşul baştan yanlış
            Console.WriteLine("\n\nKoşulu baştan yanlış olan do-while döngüsü (bir kez çalışır):");
            do
            {
                Console.Write($"{sayac4} ");
                sayac4++;
            } while (sayac4 < 5);
            
            Console.WriteLine("\n\nWhile vs Do-While Farkı:");
            Console.WriteLine("- While: Koşul önce kontrol edilir, sonra işlem yapılır.");
            Console.WriteLine("- Do-While: İşlem önce yapılır, sonra koşul kontrol edilir.");
        }

        // 4. Ödev: Çalışan Maaş Hesaplaması
        static void CalisanMaasHesaplama()
        {
            Console.WriteLine("===== ÇALIŞAN MAAŞ HESAPLAMASI =====");
            
            // Çalışan listesi oluşturma
            List<Calisan> calisanlar = new List<Calisan>
            {
                new Calisan("Ahmet", "Yılmaz", "Genel Müdür (GM)", 25000, "Yönetim"),
                new Calisan("Mehmet", "Kaya", "Müdür (MU)", 18000, "İnsan Kaynakları"),
                new Calisan("Ayşe", "Demir", "Programcı (PR)", 15000, "Yazılım"),
                new Calisan("Fatma", "Şahin", "Programcı (PR)", 14000, "Yazılım"),
                new Calisan("Ali", "Öztürk", "Stajyer (S)", 5500, "Yazılım")
            };
            
            // Çalışanları listeleme
            Console.WriteLine("\nÇalışan Listesi:");
            Console.WriteLine("----------------");
            
            double toplamMaas = 0;
            foreach (var calisan in calisanlar)
            {
                calisan.BilgileriGoster();
                toplamMaas += calisan.Maas;
            }
            
            Console.WriteLine("\nToplam Maaş: " + toplamMaas.ToString("C2"));
            Console.WriteLine("Ortalama Maaş: " + (toplamMaas / calisanlar.Count).ToString("C2"));
        }

        // 5. Ödev: Arabaların Benzin Tüketimi
        static void ArabaBenzinTuketimi()
        {
            Console.WriteLine("===== ARABALARIN BENZİN TÜKETİMİ =====");
            
            // Araba listesi oluşturma
            List<Araba> arabalar = new List<Araba>
            {
                new Araba("Toyota", "Corolla", 2020, 6.2),
                new Araba("Honda", "Civic", 2019, 6.5),
                new Araba("Volkswagen", "Golf", 2021, 5.8),
                new Araba("BMW", "320i", 2018, 7.2),
                new Araba("Mercedes", "C180", 2022, 7.0)
            };
            
            // Arabaları listeleme
            Console.WriteLine("\nAraba Listesi:");
            Console.WriteLine("--------------");
            
            double toplamTuketim = 0;
            foreach (var araba in arabalar)
            {
                araba.BilgileriGoster();
                toplamTuketim += araba.BenzinTuketimi;
            }
            
            Console.WriteLine("\nToplam Benzin Tüketimi: " + toplamTuketim.ToString("F2") + " lt/100km");
            Console.WriteLine("Ortalama Benzin Tüketimi: " + (toplamTuketim / arabalar.Count).ToString("F2") + " lt/100km");
            
            // 100 km'de toplam ne kadar yakıt tüketiliyor
            Console.WriteLine("\n100 km'de tüm araçların toplam tükettiği yakıt: " + toplamTuketim.ToString("F2") + " litre");
            
            // 1000 km'de toplam ne kadar yakıt tüketiliyor
            Console.WriteLine("1000 km'de tüm araçların toplam tükettiği yakıt: " + (toplamTuketim * 10).ToString("F2") + " litre");
        }
    }
}
