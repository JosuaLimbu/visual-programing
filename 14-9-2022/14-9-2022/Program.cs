using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pewarisan2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Virus virus1 = new Virus();
            Trojan trojan1 = new Trojan();
            Worm worm1 = new Worm();

            virus1.nama = "Sality32.exe";
            virus1.size = 32;
            virus1.banyak = 10;
            virus1.kemampuan = "Menghapus file penting";
            virus1.menyerang();
            virus1.MemperbanyakDiri();

            trojan1.nama = "BackDoorWin32.exe";
            trojan1.kemampuan = "Shutdown setiap 30 menit";
            trojan1.menyerang();
            trojan1.MenyembunyikanFile();

            worm1.nama = "Brontox.exe";
            worm1.size = 14;
            worm1.kemampuan = "Sleep setiap 15 menit";
            worm1.menyerang();
            worm1.MenginfeksiRegistry();
            worm1.menghapusNTLDR();

            Console.Read();

        }
    }

    class Malware
    {
        public string nama;
        public int size;
        public string kemampuan;

        public void menyerang()
        {
            Console.WriteLine("{0} menyerang dengan cara {1}", this.nama, this.kemampuan);
        }
    }
    class Virus : Malware
    {
        public int banyak;

        public void MemperbanyakDiri()
        {
            Console.WriteLine("{0} memperbanyak diri sebanyak {1} kali", this.nama, this.banyak * 5);
        }
    }

    class Trojan : Malware
    {
        public void MenyembunyikanFile()
        {
            Console.WriteLine("Sembunyikan file yang ada di C:/Program File/Microsoft Office");
        }
        public void memblokirCMD()
        {
            Console.WriteLine("Blokir semua aktifitas yang menggunakan Command Prompt");
        }
    }

    class Worm : Malware
    {
        public void MenginfeksiRegistry()
        {
            Console.WriteLine("{0} menginfeksi registry", this.nama);
        }
        public void menghapusNTLDR()
        {
            Console.WriteLine("{0} menghapus NT Loader", this.nama);
        }
    }
}