using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79DersExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 2, 3, 4 };
            try
            {
                Console.WriteLine(sayilar[10]);
            }
            catch(Exception e)
            {
                Console.WriteLine("Lutfen array sayisindandan buyuk bir deger girmeyiniz!");
            }
        }
    }
}
