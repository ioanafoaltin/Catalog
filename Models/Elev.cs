using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    class Elev
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }
        public SpecializareEnum Specializare { get; set; } 
        List<NotaPerMaterie> Note { get; set; }


    }
}
