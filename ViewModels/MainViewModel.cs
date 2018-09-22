using Catalog.ViewModel;
using Catalog.Views;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Catalog.ViewModels
{
    class MainViewModel
    {
        public DelegateCommand AdaugaMaterieComand { get; private set; }

        public ObservableCollection<MaterieViewModel> Materii { get; set; }

        //List<tip de date> numeleListei
        public MainViewModel()
        {
            AdaugaMaterieComand = new DelegateCommand(AdaugaMaterieComand_Execute);
            Materii = new ObservableCollection<MaterieViewModel>();

            Materie matematica = new Materie();
            matematica.Nume = "matematica";
            //matematica.Specializari = new List<SpecializareEnum>();

            matematica.Specializari.Add(SpecializareEnum.MateInfo);
            matematica.Specializari.Add(SpecializareEnum.BioChimie);

            MaterieViewModel matematicaVM = new MaterieViewModel(matematica);

            Materii.Add(matematicaVM);
        }

        private void AdaugaMaterieComand_Execute()
        {
            AdaugaMaterieViewModel adaugaMaterieViewModel = new AdaugaMaterieViewModel();
            adaugaMaterieViewModel.MainViewModel = this;

            Window fereastraNoua = new Window();
            fereastraNoua.Title = "Creaza materie noua";
            fereastraNoua.MinWidth = 50;
            fereastraNoua.MinHeight = 50;
            fereastraNoua.Width = 300;
            fereastraNoua.Height = 300;
            fereastraNoua.Content = new AdaugaMaterieView();
            fereastraNoua.DataContext = adaugaMaterieViewModel;

            adaugaMaterieViewModel.Window = fereastraNoua; 

            fereastraNoua.ShowDialog();
        }
    }
}
