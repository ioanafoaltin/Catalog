using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.ViewModels
{
    class AdaugaProfesorViewModel
    {
        private string _nume;
        private string _prenume;
        private int _varsta;

        public string Nume
        {
            get { return _nume; }
            set { _nume = value;
                //OkCommand.RaiseCanExecuteChanged();
            }
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

        public DelegateCommand Okcomand { get; private set; }

        public AdaugaProfesorViewModel() //constructor
        {
            Okcomand = new DelegateCommand(Okcomand_Execute, Okcomand_CanExecute); //ii spun sa genereze metoda. pentru ca OkComand_Execute e metoda
        }

        private bool Okcomand_CanExecute()
        {
            if(Nume == "" || Prenume == "" || Varsta == 0)
            {
                return false;
            }
            return true;
        }

        private void Okcomand_Execute()
        {
            
        }
    }
}


//public AdaugaMaterieViewModel()
//{
  //  OkCommand = new DelegateCommand(OKCommand_Execute, OKCommand_CanExecute);
//}