using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_dönüs_tipi metot_adi(parametreListesi/arguman)
            //{
            //komutlar;
            //return;
            //}
            int a = 2;
            int b = 3;
            Console.WriteLine(a + b);
            int sonuc = Topla(a, b);
            Console.WriteLine(sonuc);
            Methotlar ornek = new Methotlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            int sonuc2 = ornek.Arttır_Topla(ref a, ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString(a + b));

        }
        static int Topla(int deger1, int deger2)
        {
            return (deger1 + deger2);
        }
    }
    class Methotlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
        public int Arttır_Topla(ref int deger1, ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return deger1 + deger2;
        }
    }
}
