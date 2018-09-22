using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.ViewModels
{
    class AdaugaElevViewModel
    {
        private string _nume;
        private string _prenume;
        private int _varsta;

        public string Nume
        {
            get { return _nume; }
            set { _nume = value; }
        }

        public string Prenume
        {
            get { return _prenume; }
            set { _prenume = value; }
        }

        public int Varsta
        {
            get { return _varsta; }
            set { _varsta = value; }
        }
          
    }
}
