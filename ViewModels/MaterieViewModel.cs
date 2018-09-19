using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.ViewModel
{
    class MaterieViewModel
    {
        #region Members
        #endregion Members

        #region Properties

        public string Nume { get; set; }

        public Materie Model { get; private set; }

        public List<SpecializareEnum> Specializari { get; set; }

        #endregion Properties

        #region Constructors

        public MaterieViewModel(Materie model)
        {
            Model = model;

            Nume = Model.Nume;
            Specializari = Model.Specializari;
        }

        #endregion Constructors

        #region Methods
        #endregion Methods
    }
}
