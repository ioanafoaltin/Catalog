using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog
{
    class Materie
    {
        public String Nume { get; set; }
        public List<SpecializareEnum> Specializari { get; set; }

        public Materie()
        {
            Specializari = new List<SpecializareEnum>();
        }
    }
}
