using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarazitaProvaComune5
{
    class Maratona
    {
        public List<Atleti> elencoAtleti;
        public Maratona()
        {
            elencoAtleti = new List<Atleti>();
        }
        public void Aggiungi(Atleti atleti)
        {
            elencoAtleti.Add(atleti);
        }
        public void LeggiDati()
        {
            using (FileStream flussoDati = new FileStream("DatiMaratona.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader lettoreDati = new StreamReader(flussoDati))
                {
                    while (!lettoreDati.EndOfStream)
                    {
                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('%');

                        Atleti atleti = new Atleti();
                        atleti.Nome = campi[0];
                        atleti.Societa = campi[1];
                        atleti.Tempo = campi[2];
                        atleti.Citta = campi[3];

                        Aggiungi(atleti);

                    }
                }
            }
        }

    }
}
