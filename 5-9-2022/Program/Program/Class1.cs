using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas
{
    internal class Tampilan
    {
        static void Main(string[] args)
        {
            Biodata bio1 = new Biodata();
            Console.Write("Masukkan Nama : ");
            bio1.nama = Console.ReadLine();

            Console.Write("Masukkan Tanggal Lahir : ");
            bio1.tanggallahir = Console.ReadLine();

            Console.Write("Masukkan Umur : ");
            bio1.umur = Console.ReadLine();

            Console.Write("Masukkan Jenis Kelamin : ");
            bio1.jeniskelamin = Console.ReadLine();
        }
    }
}
