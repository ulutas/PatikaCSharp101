using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriTipiDonusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //implicit conversion

            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            Console.WriteLine("d:" + d);

            long h = d;
            Console.WriteLine("h:" + h);

            float i = h;
            Console.WriteLine("i:" + i);

            string e = "zikriye";
            char f = 'k';
            object g = e + f + d;
            Console.WriteLine("g:" + g);

            //explicit conversion

            Console.WriteLine("****** explicit conversion *****");

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v:" + v);

            // tostring method
            Console.WriteLine("****** tostring conversion *****");
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy:" + yy);

            string zz = 12.5f.ToString();
            Console.WriteLine("zz:" + zz);

            //system convert
            Console.WriteLine("****** system conversion *****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam:" + Toplam);

            //parse
            Console.WriteLine("****** parse method *****");
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            Console.WriteLine("rakam1:" + rakam1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("double1:" + double1);

        }
    }
}
