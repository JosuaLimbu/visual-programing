using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    internal class program
    {
        static void Main(string[] args)
        {
            Biodata Biodata1 = new Biodata();

            Biodata1.bio1("Josua Limbu");
            Biodata1.bio2("UNKLAB");
            Biodata1.bio3("20");
            Biodata1.bio4("212");
            Biodata1.bio5("Laki-Laki");
        }
    }
    class Biodata
    {
        public string nama;
        public string alamat;
        public string umur;
        public string kamar;
        public string jeniskelamin;


        public void bio1(string Nama1)
        {
            this.nama = Nama1;
            Console.WriteLine("Nama : {0}", this.nama);
        }

        public void bio2(string Alamat1)
        {
            this.alamat = Alamat1;
            Console.WriteLine("Alamat : {0}", this.alamat);
        }

        public void bio3(string Umur1)
        {
            this.umur = Umur1;
            Console.WriteLine("Umur : {0}", this.umur);
        }

        public void bio4(string Kamar1)
        {
            this.kamar = Kamar1;
            Console.WriteLine("Nomor Kamar : {0}", this.kamar);
        }

        public void bio5(string JenisKelamin1)
        {
            this.jeniskelamin = JenisKelamin1;
            Console.WriteLine("Jenis Kelamin : {0}", this.jeniskelamin);
        }

    }
}
