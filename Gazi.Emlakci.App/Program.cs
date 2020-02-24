using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gazi.Emlakci.App
{
    class Program
    {
        //Classlar nesneleri içinde bulunduruyor.(Nesne:davranış,özellikler bütünü)
        //Class yazmak kendi özelliklerimizi tanımlamaktır.
        static void Main(string[] args)
        {
            Araba a;
            a = new Araba();

            a.km = 0;
            a.marka = "bmw";
            a.model = "3.20";
            a.uretimyil = 2020;

            Araba b = new Araba();
            b.km = 15000;
            b.marka = "mercedes";

            a = b; //Referans aktarımı
            //Console.WriteLine(b.marka);

            Araba c = new Araba(); //c=null  yazarsak değersiz olur (referansın karşısında değer yoksa null'dur)
            c.marka = "audi";

            c = a;

            //if (c!=null) //Null Check(null olursa yazdırmayacaksak böyle yapıyoruz.
            //{
            //    Console.WriteLine(c.marka);
            //}

            Console.WriteLine(c.marka);
            Console.ReadLine();
        }
    }

    class Araba
    {
        //public-private: Erişim Belirleyiciler(Access Modifiers)
        public int km; //field (Bu alanlara field(alan) deniliyor)
        public string model; //(private yazmasakta olur.Public ulaşılabilir,private özel olan)
        public string marka;
        public int uretimyil;
    }
}
