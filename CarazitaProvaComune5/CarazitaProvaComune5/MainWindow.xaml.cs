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

namespace CarazitaProvaComune5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Maratona maratona;
        public MainWindow()
        {
            InitializeComponent();
            maratona = new Maratona();
            DgElencoAltleti.ItemsSource = maratona.elencoAtleti;
        }

        private void BtnVisualAtleti_Click(object sender, RoutedEventArgs e)
        {
            string città = TxtCittaRicerca.Text;
            foreach (var atleti in maratona.elencoAtleti)
                if (atleti.Citta == città)
            {
                    LblAtletiPartecipanti.Content += atleti.Nome + ", ";
            }

        }

        private void BtnTempo_Click(object sender, RoutedEventArgs e)
        {
            string atleta = TxtAtleta.Text;
            string città = TxtCitta.Text;
            foreach (var atleti in maratona.elencoAtleti)
            {
                if(atleti.Nome == atleta && atleti.Citta== città)
                {
                    LblTempi.Content = atleti.Tempo;
                }
            }
            
        }

        private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e)
        {
            maratona.LeggiDati();
            DgElencoAltleti.Items.Refresh();
        }
    }
}
