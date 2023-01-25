using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biodata
{
    internal class Class1
    {
        private int no_kamar;
        private string nama_asrama;
        private string hobby;
        private string skill;
        private int semester;


       
        public string Nama_asrama { get => nama_asrama; set => nama_asrama = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public string Skill { get => skill; set => skill = value; }
        public int Semester { get => semester; set => semester = value; }
        public int No_kamar { get => no_kamar; set => no_kamar = value; }
    }
}
