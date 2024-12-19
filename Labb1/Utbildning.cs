using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Utbildning
    {
        public string Namn;
        public int Startår;
        public string Akronym;

    }

    public class Systemvetarutbildningen
    {
        public Utbildning utbildning;

        public List<Kurs> Kurs;
    }
}
