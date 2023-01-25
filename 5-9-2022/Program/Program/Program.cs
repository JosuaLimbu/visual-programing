using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot1 = new Robot();

            Console.Write("Masukkan Nama : ");
            robot1.nama = Console.ReadLine();
            robot1.jumlahkaki = 5;
            robot1.jumlahtangan = 2;
            robot1.jumlahsenjata = 2;
            robot1.jumlahroket = 7;

            Console.WriteLine("Nama Robot adalah {0}", robot1.nama);
            Console.WriteLine("Jumlah Kaki Robot ada {0}", robot1.jumlahkaki);
            Console.WriteLine("Jumlah tangan robot ada {0}", robot1.jumlahtangan);
            Console.WriteLine("Jumlah senjata robot ada {0}", robot1.jumlahsenjata);
            Console.WriteLine("Jumlah roket robot ada {0}", robot1.jumlahtangan);

            Console.Read();


        }
    }
}