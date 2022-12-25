using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // implicit Conversion (Bilinçsiz dönüşüm)
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d;"+d);

            long h = d;
            Console.WriteLine("h;"+h);

            float i = h;
            Console.WriteLine("i:"+i);

            string e ="zikriye";
            char f = "k";
            object g = e+f+d;
            Console.WriteLine("g" +g);
            // Explicit Conversion (bilinçli dönüşüm)

            Console.WriteLine("**** Exlicit Conversion ****");
            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y"+y);

            int z = 100;
            byte t = (byte) z;
            Console.WriteLine("t"+t);

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v"+v);

            // *** Tostring Methodu ***
           
            System.Console.WriteLine("***** ToString Metodu *****");
            int xx=6;
            string yy = xx.ToString();
            System.Console.WriteLine("yy: "+yy);

            string zz = 12.5f.ToString();
            System.Console.WriteLine("zz: "+zz);

            //System.Convert
            System.Console.WriteLine("***** System.Convert sınıfı *****");

            string s1 = "10", s2 = "20";
            int sayi1,sayi2,Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            Toplam = sayi1+sayi2;
            System.Console.WriteLine("Toplam: "+Toplam);

            //Parse
            System.Console.WriteLine("***** Parse *****");
            ParseMethod();

            Console.ReadKey();

            static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            System.Console.WriteLine("Rakam1: "+rakam1);
            System.Console.WriteLine("Double1: "+double1);
        }
    }
}
