using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Lokal
    {
        public string Nr;
        public int AntalPlatser;
    }
    public class Sal
    {
        public string SalNr;
        public string SalTyp;
        public int AntalPlatser;
    }

    public class Grupprum
    {

    }
    public class Kontor
    {
        public string KontoNr;
        public Lärare lärare;
    }
}
