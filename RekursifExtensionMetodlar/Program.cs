using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekursifExtensionMetodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rekürsif  - Öz yineleme
            //3^4
            int result = 1;

            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);
            İslemler instance = new İslemler();
            Console.WriteLine(instance.Expo(3, 4));
            //Extenion Metotlar
            string ifade = "Ömer Ulutaş";
            bool sonuc = ifade.CheckSpaces();
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpaces());

            }
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLoweCase());
            int[] dizi = { 9, 3, 4, 2, 5, 0, 1 };
            dizi.SortArray();
            dizi.EkranaYazdır();
            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber());
            Console.WriteLine(ifade.GetFirstCharacter());



        }
    }
    public class İslemler
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
            {
                return sayi;

            }
            return Expo(sayi, üs - 1) * sayi;

        }
    }
    public static class Extention
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(' ');
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {

            return param.ToUpper();
        }
        public static string MakeLoweCase(this string param)
        {

            return param.ToLower();
        }
        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdır(this int[] param)
        {
            foreach (var item in param)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }
        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
