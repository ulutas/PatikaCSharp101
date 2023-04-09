using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sayi = "999";
            int outSayi;
            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız ");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplam);
            Console.WriteLine(toplam);

            //metotlara Aşırı Yükleme
            int ifade = 999;

            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("Ömer", "ULUTAŞ");
            //metot imzası metotadı + parametre sayısı+ parametre tipi

        }
        class Metotlar
        {
            public void Topla(int a, int b, out int toplam)
            {
                toplam = a + b;
            }
            public void EkranaYazdır(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdır(int veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdır(string veri1, string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        }
    }
}