
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuanHesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Puan Hesaplama *****");

            

            string ad, soyad;

            Console.Write("Adınızı Giriniz:");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz:");
            soyad = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("**** SINAV BİLGİLERİ ****");

                double  sınav1, sınav2, sınav3, proje,ortalama;

            Console.Write("1. Sınavı Giriniz:");
            sınav1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sınavı Giriniz:");
            sınav2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("3.Sınavı Giriniz:");
            sınav3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Projeyi Giriniz:");
            proje = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Öğrencinin Adı:{0}-Öğrencinin Soyadı:{1} ", ad, soyad);
            Console.WriteLine();

            ortalama = (sınav1 + sınav2 + sınav3 + proje) / 4;

            Console.WriteLine("Öğrencinin Ortalaması:{0}", ortalama);

            //COMPUTER SCIENCE TRYING

            Console.Read();
        }
    }
}
