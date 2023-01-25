using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biodata
{
    internal class program
    {
        static void Main()
        {
            Class1 josua = new Class1();
            Console.WriteLine("Masukkan Nomor Kamar : ");
            josua.No_kamar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Nama Asrama : ");
            josua.Nama_asrama = Console.ReadLine();
            Console.WriteLine("Masukkan Hobby : ");
            josua.Hobby = Console.ReadLine();
            Console.WriteLine("Masukkan Skill : ");
            josua.Skill = Console.ReadLine();
            Console.WriteLine("Masukkan Semester : ");
            josua.Semester = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nomor Kamar : {0}", josua.No_kamar);
            Console.WriteLine("Nama Asrama : {0}", josua.Nama_asrama);
            Console.WriteLine("Hobby : {0}", josua.Hobby);
            Console.WriteLine("Skill : {0}", josua.Skill);
            Console.WriteLine("Semester : {0}", josua.Semester);
        }
    }
    
}
