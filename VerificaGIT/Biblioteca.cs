using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificaGIT
{
    internal class Biblioteca
    {
        private string nome;
        private string indirizzo;
        private string orario_apertura;
        private string orario_chiusura;
        private List<Libro> libri;

        public Biblioteca(string nome, string indirizzo, string orario_apertura, string orario_chiusura, List<Libro> libri)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.orario_apertura = orario_apertura;
            this.orario_chiusura = orario_chiusura;
            this.libri = libri;
        }

        public void AggiungiLibro(Libro libro)
        {
            libri.Add(libro);
        }

        public bool CercaLibroConTitolo(string titolo)
        {
            for (int i = 0; i < libri.Count; i++)
            {
                if (libri[i].Titolo.ToUpper() == titolo.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }

        public List<Libro> CercaLibriConAutore(string autore)
        {
            List<Libro> libri_stesso_autore = new List<Libro>();

            for (int i = 0; i < libri.Count; i++)
            {
                if (libri[i].Autore.ToUpper() == autore.ToUpper())
                {
                    libri_stesso_autore.Add(libri[i]);
                }
            }

            return libri_stesso_autore;
        }

        public int LibriPresenti()
        {
            return libri.Count;
        }
            
    }
}
