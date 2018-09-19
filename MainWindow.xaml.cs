using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Catalog.ViewModel;
using Catalog.Views;
using Catalog.ViewModels;

namespace Catalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Materie matematica = new Materie();
            matematica.Nume ="matematica";
            //matematica.Specializari = new List<SpecializareEnum>();

            matematica.Specializari.Add(SpecializareEnum.MateInfo);
            matematica.Specializari.Add(SpecializareEnum.BioChimie);

            MaterieViewModel matematicaVM = new MaterieViewModel(matematica);

            // am setat "sursa de date [aka DataContext]" al viewului meu. 
            viewultMEu.DataContext = matematicaVM;
        }

        private void adaugaMaterie_Click(object sender, RoutedEventArgs e)
        {
            Window fereastraNoua = new Window();
            fereastraNoua.Title = "Creaza materie noua";
            fereastraNoua.MinWidth = 50;
            fereastraNoua.MinHeight = 50;
            fereastraNoua.Width = 150;
            fereastraNoua.Height = 150;
            fereastraNoua.Content = new AdaugaMaterieView();
            fereastraNoua.DataContext = new AdaugaMaterieViewModel();

            fereastraNoua.ShowDialog();
        }
    }
}
