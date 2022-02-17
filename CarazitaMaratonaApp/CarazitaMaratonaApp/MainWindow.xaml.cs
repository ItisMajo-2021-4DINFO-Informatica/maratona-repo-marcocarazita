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

namespace CarazitaMaratonaApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       Documenti documenti
            ;

        public MainWindow()
        {
            InitializeComponent();
            documenti = new Documenti();
            DgElencoBrani.ItemsSource = documenti.elencoDati;
        }

        private void BtnLeggiDaFile_Click(object sender, RoutedEventArgs e)
        {
            documenti.LeggiDati();
            DgElencoBrani.Items.Refresh();
        }

        private void BtnCercaArtista_Click(object sender, RoutedEventArgs e)
        {
            string titolo = TxtTitolo.Text;
            // eventualmente aggiungo un controllo sull'input
            string artistaTrovato = documenti.CercaAtleta(titolo);
            LblArtista.Content = artistaTrovato;
        }

        private void BtnContaBrani_Click(object sender, RoutedEventArgs e)
        {
            string album = TxtAlbum.Text;
            // eventualmente aggiungo un controllo sull'input
            string numeroBrani = documenti.CittaCorsa(album);
            LblNumBrani.Content = numeroBrani;
        }

        private void BtnDurata_Click(object sender, RoutedEventArgs e)
        {
            string durata = dati.CalcolaDurata();
            LblNumBrani.Content = durata;
        }
    }
}
