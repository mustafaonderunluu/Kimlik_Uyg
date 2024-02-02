using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimlik_Uyg
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Kimlik kml = new Kimlik();

            kml.AD = "Mustafa Önder ";
            kml.SOYAD = "Ünlü";
            kml.MEMLEKET = "İstanbul ";

            Console.WriteLine(kml.AD);
            Console.WriteLine(kml.SOYAD);
            Console.WriteLine(kml.MEMLEKET);
            Console.WriteLine(kml.YAS);
            Console.WriteLine(kml.CINSIYET);
            Console.ReadKey();  
        }
    }
}
