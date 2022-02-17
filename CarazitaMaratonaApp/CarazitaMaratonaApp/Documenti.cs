using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarazitaMaratonaApp
{
    class Documenti
    {
        public List<Documento> elencoDati;

        public Documenti()
        {
            elencoDati = new List<Documento>();
        }

        public void Aggiungi(Documento documento)
        {
            elencoDati.Add(documento);
        }

        public void LeggiDati()
        {
            using (FileStream flussoDati = new FileStream("discografia.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader lettoreDati = new StreamReader(flussoDati))
                {
                    while (!lettoreDati.EndOfStream)
                    {
                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('*');

                        Documento documento = new Documento();
                        documento.NomeAtleta = campi[0];
                        documento.Societa = campi[1];
                        documento.Minuti = campi[2];
                        documento.Secondi = campi[3];
                        documento.CittaCorsa = campi[4];

                        Aggiungi(documento);

                    }
                }
            }
        }

        public string CercaAtleta(string societa)
        {
            string atleta = societa + "--NON TROVATO--";

            foreach (var documento in elencoDati)
            {
                if (documento.Societa == societa)
                {
                    atleta = documento.NomeAtleta;
                }
            }

            return atleta;
        }

   

        public string CalcolaDurata()
        {
            string durata = "0";

            return durata.ToString();
        }
    }
}
