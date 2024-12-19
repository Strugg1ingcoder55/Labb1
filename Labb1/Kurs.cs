using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Models
{
    public class Kurs
    {
        public string Kursnamn;
        public string Kurskod;

        public DateTime Starttid;
        public DateTime Sluttid;

        public Lärare Lärare;
        public List<Student> Student = new List<Student>();
        public int FåTillbakaStudent()
        {

            return Student.Count;
        }
    }

    public class Tentamen
    {
        public Sal Sal;

    }
}
