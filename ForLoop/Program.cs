using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Loop ve Break Continue Ifadeleri");
            Console.Write("Lütfen bir sayi giriniz:");
            int sayac = int.Parse(Console.ReadLine());

            for (int i = 0; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            // 1 ile 1000 arasındaki tek ve çitf sayıların kendi içlerindeki toplamları ekrana yazdır.
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i; // ciftToplam = ciftToplam + i
                else
                    tekToplam += i; // tekToplam = tekToplam + i
            }

            Console.WriteLine("1000'e kadar olan çift sayıların toplamı:" + ciftToplam);
            Console.WriteLine("1000'e kadar olan tek sayıların toplamı:" + tekToplam);

            // break, continue
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
