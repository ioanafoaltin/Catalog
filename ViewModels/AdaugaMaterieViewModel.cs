using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Catalog.ViewModels
{
    class AdaugaMaterieViewModel
    {
        private string _nume;
        private bool _IsMateInfoChecked;
        private bool _isUmanCheched;
        private bool _isBioChimieChecked;

        public string Nume
        {
            get { return _nume; }
            set
            {
                _nume = value;

                OkCommand.RaiseCanExecuteChanged();
            }
        }

        public bool IsMateInfoChecked
        {
            get { return _IsMateInfoChecked; }
            set
            {
                _IsMateInfoChecked = value;
                OkCommand.RaiseCanExecuteChanged();
            }
        }

        public bool IsUmanChecked
        {
            get { return _isUmanCheched; }
            set
            {
                _isUmanCheched = value;
                OkCommand.RaiseCanExecuteChanged();
            }
        }
        public bool IsBioChimieChecked
        {
            get { return _isBioChimieChecked; }
            set
            {
                _isBioChimieChecked = value;
                OkCommand.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand OkCommand { get; set; }

        public AdaugaMaterieViewModel()
        {
            OkCommand = new DelegateCommand(OKCommand_Execute, OKCommand_CanExecute);
        }

        private void OKCommand_Execute()
        {

        }

        private bool OKCommand_CanExecute()
        {
            if (Nume == "")
            {
                return false;
            }

            if (!IsBioChimieChecked && !IsMateInfoChecked && !IsUmanChecked)
            {
                return false;
            }

            return true;
        }
    }
}
