using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diziler");
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Balık" };
            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";

            dizi[3] = 10;
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerde Dizi Kullanımı
            //Klavyeden girilen n tane sayının ortalamsını hesaplayan program
            Console.Write("Lütfen dizinin eleman sayısını giriniz : ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0} . sayıyı giriniz", i + 1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayi in sayıDizisi)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalamanız = " + toplam / diziUzunlugu);

            //ARRAY SINIFI METODLARI
            // Start 
            int[] sayiDizisi = { 23, 13, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("*** Sırasız bir dizi ***");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("*** Sıralı bir dizi ***");
            Array.Sort(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("*** Array Clear ***");
            // sayiDizisi elemanlarını kullanarak 2.index ten itibaren 2 tane elemanı 0 lar
            Array.Clear(sayiDizisi, 2, 2);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Reverse 
            Console.WriteLine("*** Array Reverse ***");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //IndexOf
            Console.WriteLine("*** Array IndexOf ***");
            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));

            //Resive 
            Console.WriteLine("*** Array Resize ***");
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;

            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.ReadKey();
        }
    }
}
