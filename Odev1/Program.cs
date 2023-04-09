using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru1();
            //Soru2();
            //Soru3();
            Soru4();
            
            Console.ReadLine();
            
        }
        private static void Soru1() 
        {
            Console.WriteLine("Bir Sayı giriniz : ");
            int sayi = int.Parse(Console.ReadLine());

            Console.WriteLine("Adet Sayısı giriniz : ");
            int sayi2 = int.Parse(Console.ReadLine());
            for (int i = sayi; i < sayi2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        private static void Soru2()
        {
            Console.WriteLine("1.Sayıyı giriniz : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("2.Sayıyı giriniz : ");
            int m = int.Parse(Console.ReadLine());
            if (n == m || n % m == 0)
            {
                Console.Write(n);
            }

            Console.WriteLine("Bir Sayı Giriniz : ");
            int sayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir Kelime Giriniz : ");
        }
        private static void Soru3()
        {
            Console.WriteLine("Pozitif Bir Sayi Girin : ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi <= 0)
            {
                Console.WriteLine("Lütfen pozitif bir sayı girin : ");
                sayi = int.Parse(Console.ReadLine());
            }

            string[] kelimeler = new string[sayi];
            for (int i = 1; i <= sayi; i++)
            {
                Console.WriteLine(i + " .Kelimeyi Giriniz  :  ");
                string sayi2 = Console.ReadLine();
                kelimeler[i] = sayi2;

            }

            Array.Reverse(kelimeler);
            foreach (var item in kelimeler)
            {

                Console.WriteLine(item);
            }
        }
        private static void Soru4()
        {
            Console.WriteLine("Cümle yazınız.");
            string input = Console.ReadLine();
            string[] words = input.Split(' ');
            int w = words.Count();
            char[] c = input.Replace(" ", string.Empty).ToCharArray();
            int c1 = c.Count();
            Console.WriteLine("Kelime sayısı: {0},\tHarf sayısı: {1}", w, c1);
        }
    }
}
