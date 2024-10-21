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
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Aggiungi_Click(object sender, RoutedEventArgs e)
        {
            if (Autore.Text == "" || Titolo.Text == "" || AnnoPubblicazione.Text == "" || Editore.Text == "" || Pagine.Text == "")
                MessageBox.Show("Ci sono dei campi vuoti, riempili"); 
            //else
            //{
            //    Libro libro = new Libro(Autore.Text, Titolo.Text, AnnoPubblicazione.Text, Editore.Text, Pagine.Text);
                
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TitoloTrovare.Text == "")
                MessageBox.Show("Devi inserire un titolo valido. riprova");
            //else
            //{
            //    TODO: Richiamare la funzione corretta

            //}
        }

        private void Calcola_Click(object sender, RoutedEventArgs e)
        {
            // Numero.Text = TODO
        }

        private void Lettura_CLick(object sender, RoutedEventArgs e)
        {
            if (Autore.Text == "" || Titolo.Text == "" || AnnoPubblicazione.Text == "" || Editore.Text == "" || Pagine.Text == "")
                MessageBox.Show("Ci sono dei campi vuoti, riempili");
            else
            {
                //TODO: richiamare funzione corretta
            }
        }
    }
}