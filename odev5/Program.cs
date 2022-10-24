using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.sayıyı giriniz : ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.sayıyı giriniz : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            if (sayi1 % sayi2 == 0)
            {
                Console.WriteLine("Birbirlerine tam bölünebilirler");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Birbilerine tam bölünemezler");
                Console.ReadLine();
            }
        }
    }
}
