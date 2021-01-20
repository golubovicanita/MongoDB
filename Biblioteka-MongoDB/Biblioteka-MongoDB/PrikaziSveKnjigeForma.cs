using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;

namespace Biblioteka_MongoDB
{
    public partial class PrikaziSveKnjigeForma : Form
    {
        Biblioteka B;
        Korisnik K;
        public PrikaziSveKnjigeForma()
        {
            InitializeComponent();
            
        }
        public PrikaziSveKnjigeForma(Biblioteka b)
        {
            InitializeComponent();
            B = b;
            K = null;
           

        }
        public void popuniPodacima()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionB = db.GetCollection<Biblioteka>("biblioteka");
            var collectionK = db.GetCollection<Knjiga>("knjige");

            this.listaKnjiga.Items.Clear();
            var builder = Builders<Knjiga>.Filter;
            var filter = builder.Where(x => x.Biblioteka.Id == B.Id);
            var list = collectionK.Find(filter).SortBy(y => y.Naslov).ToList();
            foreach (Knjiga k in list)
            {

                ListViewItem item = new ListViewItem(new string[] {  k.Naslov.ToString(), k.Autor.ToString(), k.Zanr.ToString(), k.GodinaIzdavanja.ToString(), k.BrojPrimeraka.ToString(), k.Id.ToString() });
                this.listaKnjiga.Items.Add(item);
            }
            this.listaKnjiga.Refresh();

        }
        private void PrikaziSveKnjigeForma_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnListaZelja_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionB = db.GetCollection<Biblioteka>("biblioteka");
            var collectionK = db.GetCollection<Knjiga>("knjige");
            var collectionKorisnik = db.GetCollection<Korisnik>("korisnici");

            var naslov = this.listaKnjiga.SelectedItems[0].SubItems[0].Text;
            var builder1 = Builders<Knjiga>.Filter;
            var filter1 = builder1.Where(x => x.Naslov == naslov);
            var izabranaKnjiga = collectionK.Find(filter1).FirstOrDefault();

            string vasJMBG = this.txtJMBG.Text;
            var builder2 = Builders<Korisnik>.Filter;
            var filter = builder2.Where(x => x.JMBG == vasJMBG);
            var korisnik = collectionKorisnik.Find(filter).FirstOrDefault();
            K = korisnik;

            List<Knjiga> pomLista = new List<Knjiga>();
            pomLista = K.ListaZelja;
            pomLista.Add(izabranaKnjiga);

            var builder = Builders<Korisnik>.Filter;
            var update = Builders<Korisnik>.Update.Set("ListaZelja", pomLista);
            var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
            MessageBox.Show("Dodali ste knjigu: " + naslov + " u svoju listu zelja.");
            Refresh();


        }

        private void btnKorisnik_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionB = db.GetCollection<Biblioteka>("biblioteka");
            var collectionK = db.GetCollection<Knjiga>("knjige");
            var collectionKorisnik = db.GetCollection<Korisnik>("korisnici");

            string vasJMBG = this.txtJMBG.Text;
            var builder = Builders<Korisnik>.Filter;
            var filter = builder.Where(x => x.JMBG==vasJMBG);
            var korisnik = collectionKorisnik.Find(filter).FirstOrDefault();
            K = korisnik;
            if (K == null)
            {
                MessageBox.Show("Korisnik se ne nalazi u bazi podataka, unesite svoje podatke!");
                Refresh();
                UnosKorisnikaForma forma = new UnosKorisnikaForma();
                forma.ShowDialog();
            }
            else
            {
                
                MessageBox.Show("Nalazite se na listi korisnika, izaberite knjige koje zelite da unesete u svoju listu zelja.");
                Refresh();
            }

        }

        private void btnZelje_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionKorisnik = db.GetCollection<Korisnik>("korisnici");

            string vasJMBG = this.txtJMBG.Text;
            var builder = Builders<Korisnik>.Filter;
            var filter = builder.Where(x => x.JMBG == vasJMBG);
            var korisnik = collectionKorisnik.Find(filter).FirstOrDefault();
            Refresh();
            PrikaziListuZelja forma = new PrikaziListuZelja(korisnik);
            if (korisnik.ListaZelja.Count == 0)
            {
                MessageBox.Show("Lista zelja je prazna, unesite svoj JMBG i izaberite knjigu za listu zelja.");
            }
            else
            {
                Refresh();
                forma.ShowDialog();
                
            }
            Refresh();
            popuniPodacima();
          
        }
    }
}
