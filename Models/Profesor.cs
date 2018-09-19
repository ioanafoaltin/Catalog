using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    class Profesor
    {
        //proprietati
        public String Nume { get; set; }
        public string Prenume { get; set; }
        public Materie Materie { get; set; }
        public int Varsta { get; set; }


        public Profesor()
        {
        }
    }
}
