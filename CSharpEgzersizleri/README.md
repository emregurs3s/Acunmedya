# C# Egzersizleri

Bu proje, C# programlama dilini öğrenmek için hazırlanan bir dizi egzersizi içermektedir. Proje, konsol uygulaması olarak geliştirilmiştir.

## Projenin Çalıştırılması

Projeyi çalıştırmak için:

1. Visual Studio veya Visual Studio Code ile açın
2. Terminal/Konsol üzerinden `dotnet run` komutunu çalıştırın

## İçerdiği Egzersizler

Proje aşağıdaki egzersizleri içermektedir:

### 1. Yaş Kategorisini Belirleme

Kullanıcının girdiği yaşa göre hangi kategoride olduğunu belirleyen bir uygulama.

- 0 ile 18 arasındaysa → "Küçüksünüz"
- 18 ile 35 arasındaysa → "Gençsiniz"
- 35 ile 55 arasındaysa → "Yetişkinsiniz"
- 55 ile 75 arasındaysa → "Yaşlısınız"
- 75 ile 99 arasındaysa → "Çok yaşlısınız"
- 0'dan küçük veya 99'dan büyükse → "Ya hiç doğmadınız ya da çoktan öldünüz..."

### 2. Araba Yaşı ve Durumu

Bir arabanın yaşına göre hangi durumda olduğunu belirleyen bir uygulama. Hem if-else hem de switch-case ile yapılmış örnekler içerir.

- 0 ile 10 arasındaysa → "Arabanız yeni"
- 10 ile 20 arasındaysa → "Servise götürmeniz gerekebilir"
- 20 ile 30 arasındaysa → "Arabanız hurdaya çıkabilir"
- 0'dan küçük veya 30'dan büyükse → "Ya hiç üretilmedi ya da trafikten men edilmiştir"

### 3. While ve Do-While Döngüleri

While ve do-while döngülerinin farkını gösteren örnekler:

- While döngüsü: Önce koşulu kontrol eder, doğruysa çalışır. Koşul baştan yanlışsa hiç çalışmaz.
- Do-While döngüsü: Önce işlemi yapar, sonra koşulu kontrol eder. Koşul yanlış bile olsa en az bir kere çalışır.

### 4. Çalışanların Maaş Hesaplaması

Farklı türdeki çalışanları içeren bir liste oluşturup, toplam ve ortalama maaş hesaplamalarını yapan bir uygulama.

Çalışan türleri:
- Genel Müdür (GM)
- Müdür (MU)
- Programcı (PR)
- Stajyer (S)

### 5. Arabaların Benzin Tüketimi

Farklı arabaları içeren bir liste oluşturup, benzin tüketimlerini hesaplayan bir uygulama.

## Kodun Yapısı

Proje, OOP (Nesne Yönelimli Programlama) prensiplerine uygun olarak tasarlanmıştır:

- `Calisan` sınıfı: Çalışanlar hakkında bilgileri tutan sınıf
- `Araba` sınıfı: Arabalar hakkında bilgileri tutan sınıf
- `Program` sınıfı: Ana program akışını ve metotları içeren sınıf

Her bir egzersiz için ayrı metotlar yazılmıştır ve bunlar ana menüden seçilerek çalıştırılabilir. 