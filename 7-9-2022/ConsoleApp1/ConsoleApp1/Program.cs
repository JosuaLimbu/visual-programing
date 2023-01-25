using System;

public class Program
{
    public static void Main()
    {
       
        Biodata bio1 = new Biodata();
        Console.Write("Masukkan Nama : ");
        string josua = Console.ReadLine();
        bio1.a(josua);

        Console.Write("Masukkan Umur : ");
        josua = Console.ReadLine();
        bio1.b(josua);

        Console.Write("Masukkan Alamat : ");
        josua = Console.ReadLine();
        bio1.c(josua);

        Console.Write("Masukkan Jurusan : ");
        josua = Console.ReadLine();
        bio1.d(josua);

        Console.Write("Masukkan Tanggal Lahir : ");
        josua = Console.ReadLine();
        bio1.e(josua);

        Console.WriteLine("\nOutput");
        Console.WriteLine("Nama : {0}", bio1.aa());
        Console.WriteLine("Umur : {0}", bio1.bb());
        Console.WriteLine("Alamat : {0}", bio1.cc());
        Console.WriteLine("Jurusan : {0}", bio1.dd());
        Console.WriteLine("Tanggal Lahir : {0}", bio1.ee());

       
    }
}
