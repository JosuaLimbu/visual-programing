//Looping
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a;
            Int32 n, i=1;

            Console.WriteLine("Masukkan Jumlah Data : ");
            a = Console.ReadLine();
            n = Convert.ToInt32(a);

            while (i<=n)
            {
                Console.WriteLine("Data ke - {0}", i);
                i++
;            }
            Console.ReadLine();


        }
    }
}