//Ciao
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace VerificaGIT
{
    internal class Libro
    {
        private string autore;
        private string titolo;
        private string anno_pubblicazione;
        private string editore;
        private int pagine;

        public Libro(string autore, string titolo, string anno_pubblicazione, string editore, int pagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.anno_pubblicazione = anno_pubblicazione;
            this.editore = editore;
            this.pagine = pagine;
        }

        public string Autore { get { return autore; } set { autore = value; } }
        public string Titolo { get { return titolo; } set { titolo = value; } }
        public string Anno_Pubblicazione { get { return anno_pubblicazione; } set { anno_pubblicazione = value; } }
        public string Editore { get { return editore; } set { editore = value; } }
        public int Pagine { get { return pagine; } set { pagine = value; } }

        public string ToString(Libro libro)
        {
            return $"Autore = {Autore}, Titolo = {Titolo}, Anno Pubblicazione = {Anno_Pubblicazione}, Editore = {Editore}, Numero Pagine = {Pagine}";
        }

        public string ReadingTime(Libro libro)
        {
            if(Pagine < 100 && Pagine > 0)
            {
                return "Tempo di lettura = 1h";
            }
            else if(Pagine >= 100 && Pagine < 200)
            {
                return "Tempo di lettura = 2h";
            }
            else
            {
                return "Tempo di lettura > 2h";
            }
        }
    }
}
