using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilleLoop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Ucret ve kdv hesaplama ***
            //const double kdv = 0.18;
            //Console.WriteLine("Ucret : ");
            //double ucret = Convert.ToInt32(Console.ReadLine());

            //while (ucret > -1)
            //{
            //    double topUcret = ucret + ucret * kdv;
            //    Console.WriteLine("Ucret : " + ucret);
            //    Console.WriteLine("Kdv : % " + (kdv * 100));
            //    Console.WriteLine("Toplam ucret : " + topUcret);
            //    Console.WriteLine("Ucret : ");
            //    ucret = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine("Uygun sayi girmediğiniz için islem sonlandirildi!!!");

            // *** While ile pozitif sayi otalama hesaplama ***
            //Console.WriteLine("Lütfen pozitif bir sayi giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int adet = 0;
            //int toplam = 0;

            //while (sayi > -1)
            //{
            //    toplam += sayi;
            //    adet++;
            //    Console.WriteLine("Lütfen pozitif bir sayi giriniz : ");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //}
            //Console.WriteLine("Girdiginiz sayilarin toplami : " + toplam);
            //Console.WriteLine("Girdiginiz sayilarin ortalamasi : " + toplam / adet);

            // *** (1 * 2 - 3 * 4) + (5 * 6 - 7 * 8) + ... + (997 * 998 - 999 * 1000) ***
            //int toplam = 0;
            //int sayi;

            //for (sayi = 1; sayi <= 997; sayi += 4)
            //{
            //    toplam += sayi * (sayi + 1) - (sayi + 2) * (sayi + 3); 
            //    sayi += 4;
            //}
            //Console.WriteLine("Toplam : " + toplam);

            int toplam = 0;
            int sayi = 1;

            while (sayi <= 997)
            {
                toplam += sayi * (sayi + 1) - (sayi + 2) * (sayi + 3);
                sayi += 4;
            }
            Console.WriteLine("Toplam : " + toplam);




            Console.Read();
        }
    }
}
