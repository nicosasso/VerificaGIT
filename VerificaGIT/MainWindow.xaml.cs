using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace VerificaGIT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Biblioteca biblioteca;
        Libro libro;


        public MainWindow()
        {
            InitializeComponent();
            libro = new Libro("", "", "", "", -1);
            List<Libro> libri = new List<Libro>();
            biblioteca = new Biblioteca("", "", "", "", libri);
        }

        private void Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            if (Autore.Text == "" || Titolo.Text == "" || AnnoPubblicazione.Text == "" || Editore.Text == "" || Pagine.Text == "")
                MessageBox.Show("Ci sono dei campi vuoti, riempili"); 
            else
            {
                Libro libro = new Libro(Autore.Text, Titolo.Text, AnnoPubblicazione.Text, Editore.Text, int.Parse(Pagine.Text));
                biblioteca.AggiungiLibro(libro);
                MessageBox.Show("Libro aggiunto correttamente");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TitoloTrovare.Text == "")
                MessageBox.Show("Devi inserire un titolo valido. riprova");
            else
            {
                if(biblioteca.CercaLibroConTitolo(TitoloTrovare.Text) == true)
                {
                    MessageBox.Show("Il libro è presente nella biblioteca");
                }
                else
                {
                    MessageBox.Show("Il libro non è presente nella biblioteca");
                }

            }
        }

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            Numero.Text = $"{biblioteca.LibriPresenti()}";
        }

        private void Lettura_CLick(object sender, RoutedEventArgs e)
        {
            if (Autore.Text == "" || Titolo.Text == "" || AnnoPubblicazione.Text == "" || Editore.Text == "" || Pagine.Text == "")
                MessageBox.Show("Ci sono dei campi vuoti, riempili");
            else
            {
                MessageBox.Show($"Tempo di lettura = {libro.ReadingTime}");
            }
        }

        private void String_CLick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Autore = {Autore.Text}, Titolo = {Titolo.Text}, Anno Pubblicazione = {AnnoPubblicazione.Text}, Editore = {Editore.Text}, Pagine = {Pagine.Text}");
        }
    }
}