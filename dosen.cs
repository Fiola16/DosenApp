using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen_app
{
    class Dosen
    {
        protected string namaDosen = "Dosen Pengampu", Course = "Pemrograman Berorientasi Objek";
        protected int nik = 123456789;
        public Dosen()
        {
        }
        public void attDosen(string namaDosen, int nik)
        {
            this.namaDosen = namaDosen;
            this.nik = nik;
        }
        public void addCourse(string Course)
        {
            this.Course += $", " + Course;
        }
        public void display()
        {
            Console.WriteLine($"ID : 1");
            Console.WriteLine($"Nama : {namaDosen}");
            Console.WriteLine($"NIK : {nik}");
            Console.WriteLine("Gender : Male");
            Console.WriteLine($"Course : {Course}");
        }
    }
}
