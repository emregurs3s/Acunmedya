using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public void Calculate()
        {
            Console.WriteLine("1. sayiyi giriniz:");
            double sayi1 = 0;
            Console.WriteLine("2. sayiyi giriniz:");
            double sayi2 = 0;

            Console.WriteLine("İslem seçiniz:");
            int islem = 0;

            if (islem == 1)
            {
                Topla(sayi1, sayi2);
            }

            else if (islem == 2)
            {
                Cıkart(sayi1, sayi2);
            }

            else if (islem == 3)
            {
                Carpma(sayi1, sayi2);
            }

            else if (islem == 4)
            {
                Bolme(sayi1, sayi2);
            }
        }

        public void Topla(double sayi1, double sayi2)
        {
            Console.WriteLine("Toplama yapiliyor : .......");
            double sonuc = sayi1 + sayi2;
        }
        public void Cıkart(double sayi1, double sayi2) {
            Console.WriteLine("Cıkartma yapiliyor : .........");
            double sonuc = sayi1 - sayi2;
                }
        public void Carpma(double sayi1, double sayi2) {
            Console.WriteLine("Carpma yapiliyor : ........");
            double sonuc = sayi1 * sayi2;
        }
        public void Bolme(double sayi1, double sayi2)
        {
            Console.WriteLine("Bolme yapiliyor : ........");
            double sonuc = sayi1 / sayi2;
        }
    }
}
