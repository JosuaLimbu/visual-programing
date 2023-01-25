using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot0 = new Robot();
            RobotBeroda robot1 = new RobotBeroda();
            RobotBerkaki robot2 = new RobotBerkaki();
            RobotPenyelam robot3 = new RobotPenyelam();
            RobotTerbang robot4 = new RobotTerbang();

            robot0.Beraksi();

            robot1.nama = "Robot Beroda";
            robot1.jenissensor = "Touch Sensor";
            robot1.jumlahroda = "4";
            Console.WriteLine("{0} memiliki jenis sensor {1}", robot1.nama, robot1.jenissensor);
            robot1.Atursensor();
            robot1.Beraksi();
            Console.WriteLine("{0} memiliki jumlah roda {1}", robot1.nama, robot1.jumlahroda);


            robot2.nama = "Robot Berkaki";
            robot2.jenissensor = "Touch Sensor";
            robot2.jumlahkaki = "2";
            Console.WriteLine("{0} memiliki jenis sensor {1}", robot2.nama, robot2.jenissensor);
            robot2.Atursensor();
            Console.WriteLine("{0} memiliki jumlah kaki {1}", robot2.nama, robot2.jumlahkaki);
            robot2.Beraksi();

            robot3.nama = "Robot Penyelam";
            robot3.jenissensor = "Distance Sensor";
            robot3.jumlahbaling = "3";
            Console.WriteLine("{0} memiliki jenis sensor {1}", robot3.nama, robot3.jenissensor);
            robot3.Atursensor();
            Console.WriteLine("{0} memiliki jumlah baling {1}", robot3.nama, robot3.jumlahbaling);
            robot3.Beraksi();


            Console.Read();

        }
    }
    class Robot
    {
        public string nama;
        public string jenissensor;

        public void Atursensor()
        {
            Console.WriteLine("Mengatur sensitifitas {0}", this.jenissensor);
        }
        public void Beraksi()
        {
            Console.WriteLine("Robot {0} Beraksi", this.nama);
        }

    }
    class RobotBeroda : Robot
    {
        public string jumlahroda;
        public void Beraksi()
        {
            Console.WriteLine("Robot {0} meluncur 1 meter", this.nama);
        }
    }
    class RobotBerkaki : Robot
    {
        public string jumlahkaki;

        public void Beraksi()
        {
            Console.WriteLine("Robot {0} berjalan 10 langkah", this.nama);
        }
    }
    class RobotPenyelam : Robot
    {
        public string jumlahbaling;


        public void Beraksi()
        {
            Console.WriteLine("Robot {0} menyelam selama 2 meter", this.nama);
        }
        public void Atursensor()
        {
            Console.WriteLine("Mengatur sensitifitas tekanan air pada{0}", this.jenissensor);
        }
    }
    class RobotTerbang : Robot
    {
        public string jumlahbaling;


        public void Beraksi()
        {
            Console.WriteLine("Robot {0} berjalan 10 langkah", this.nama);
        }
    }

}