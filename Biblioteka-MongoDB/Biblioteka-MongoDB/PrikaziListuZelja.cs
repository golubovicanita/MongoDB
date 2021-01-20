using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka_MongoDB
{
    public partial class PrikaziListuZelja : Form
    {
        Korisnik korisnik;
        public PrikaziListuZelja()
        {
            InitializeComponent();
        }
        public PrikaziListuZelja(Korisnik kk)
        {
            InitializeComponent();
            korisnik = kk;

            bool vratio = korisnik.VratioKnjigu;
            this.btnIznajmi.Enabled = vratio;
            btnVrati.Enabled = !vratio;
        }
        public void popuniPodacima()
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionKorisnik = db.GetCollection<Korisnik>("korisnici");
            var collectionK = db.GetCollection<Knjiga>("knjige");

            this.listaZelja.Items.Clear();

            foreach (Knjiga k in korisnik.ListaZelja)
            {

                ListViewItem item = new ListViewItem(new string[] { k.Id.ToString(), k.Naslov.ToString(), k.Autor.ToString(), k.Zanr.ToString(), k.GodinaIzdavanja.ToString(), k.BrojPrimeraka.ToString()  });
                this.listaZelja.Items.Add(item);
            }
            this.listaZelja.Refresh();

        }

        private void PrikaziListuZelja_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionKorisnik = db.GetCollection<Korisnik>("korisnici");
            var collectionK = db.GetCollection<Knjiga>("knjige");

            string knjigaIzabranaNaslov = this.listaZelja.SelectedItems[0].SubItems[1].Text;
            List<Knjiga> pomLista = new List<Knjiga>();
            pomLista = korisnik.ListaZelja;
           
            foreach (Knjiga k in korisnik.ListaZelja.ToArray())
            {
                if (k.Naslov == knjigaIzabranaNaslov)
                {
                    pomLista.Remove(k);
                    
                }
            }

            var builder = Builders<Korisnik>.Filter;
            var filter = builder.Where(x => x.JMBG == korisnik.JMBG);
            var update = Builders<Korisnik>.Update.Set("ListaZelja", pomLista);
            var rez = collectionKorisnik.FindOneAndUpdate(filter, update);

            MessageBox.Show("Uspesno ste uklonili " + this.listaZelja.SelectedItems[0].SubItems[1].Text + " iz svoje liste.");
            Refresh();
            popuniPodacima();

        }

        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            string izabranaKnjiga = this.listaZelja.SelectedItems[0].SubItems[1].Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionKorisnik = db.GetCollection<Korisnik>("korisnici");
            var collectionK = db.GetCollection<Knjiga>("knjige");

            var builder1 = Builders<Knjiga>.Filter;
            var filter1 = builder1.Where(x => x.Naslov == izabranaKnjiga);
            var knjiga = collectionK.Find(filter1).FirstOrDefault();
            if (knjiga.BrojPrimeraka == 0)
            {
                MessageBox.Show("Knjiga trenutno nije dostupna, broj primeraka je: " + knjiga.BrojPrimeraka + ", izaberite neku drugu.");
            }
            else
            {
                List<MongoDBRef> pomLista = new List<MongoDBRef>();
                pomLista = knjiga.Korisnici;

                pomLista.Add(new MongoDBRef("Korisnici", korisnik.Id));// dodat korisnik koji je iznajmio tu knjigu

                var update = Builders<Knjiga>.Update.Set("Korisnici", pomLista);
                var rez = collectionK.FindOneAndUpdate(filter1, update);// sacuvana nova lista korisnika

                //kod korisnika da se doda ref na knjigu
                korisnik.Knjiga = new MongoDBRef("Knjiga", knjiga.Id);
                //da se sacuva izmena, tj dodata referenca na knjigu
                var builder2 = Builders<Korisnik>.Filter;
                var filter2 = builder2.Where(x => x.JMBG == korisnik.JMBG);
                var update2 = Builders<Korisnik>.Update.Set("Knjiga", korisnik.Knjiga);
                var rez2 = collectionKorisnik.FindOneAndUpdate(filter2, update2);

                //smanjiti broj primeraka knjige
                int b = knjiga.BrojPrimeraka;
                int brPrimeraka = b-1;
                var update4 = Builders<Knjiga>.Update.Set("BrojPrimeraka", brPrimeraka);
                var rez4 = collectionK.FindOneAndUpdate(filter1, update4);
                Refresh();
                //MessageBox.Show("Smanjio se broj primeraka za knjigu: " + knjiga.Naslov + ", br primeraka= " + knjiga.BrojPrimeraka);

                Refresh();
                MessageBox.Show("Potrebno je da unesete datum iznajmnjivanja knjige i rok za vracanje. Promeniti i status da li je korisnik vratio knjigu(SA True NA False)");
                Refresh();
                IzmeniPodatkeForma forma = new IzmeniPodatkeForma(korisnik);
                Refresh();
                forma.ShowDialog();
                Refresh();
                popuniPodacima();


                
                var builder5 = Builders<Knjiga>.Filter;
                var filter5 = builder5.Where(x => x.Naslov == izabranaKnjiga);
                var kk = collectionK.Find(filter5).FirstOrDefault();
                MessageBox.Show("Iznajmili ste knjigu: " + kk.Naslov + ", novi broj primeraka: " + kk.BrojPrimeraka);
                
                popuniPodacima();
                Refresh();
                Close();
            }

           

        }

        private void btnVrati_Click(object sender, EventArgs e)
        {
            //da izbrisem iz korisnik.Knjiga
            //da izbrisem iz knjiga.Korisnici ovu knjigu
            //da povecam br primeraka

          
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionKorisnik = db.GetCollection<Korisnik>("korisnici");
            var collectionK = db.GetCollection<Knjiga>("knjige");

            var builder = Builders<Knjiga>.Filter;
            var filter = builder.Where(x => x.Id == korisnik.Knjiga.Id);// nalazim knjigu sa korisnikove ref na knjigu
            var knjiga = collectionK.Find(filter).FirstOrDefault();

            //iz te knjige izbacujem tog korisnika
            List<MongoDBRef> pom = new List<MongoDBRef>();
            pom = knjiga.Korisnici;
            foreach(MongoDBRef k in pom.ToArray())
            {
                if (k.Id == korisnik.Id)
                {
                    pom.Remove(k);
                }
            }
            var update = Builders<Knjiga>.Update.Set("Korisnici", pom);
            var rez = collectionK.FindOneAndUpdate(filter, update);
            MessageBox.Show("Uklonili ste referencu na korisnika.");

    
            var builder2 = Builders<Korisnik>.Filter;
            var filter2 = builder2.Where(x => x.Knjiga.Id == knjiga.Id);
            var update4 = Builders<Korisnik>.Update.Set("Knjiga", BsonNull.Value);
            var rez4 = collectionKorisnik.FindOneAndUpdate(filter2, update4);
           
            MessageBox.Show("Korisnik: " + korisnik.Ime + " " + korisnik.Prezime + " je vratio knjigu: " + knjiga.Naslov);

            //promeni status na True
            MessageBox.Show("Promenite da je vratio knjigu sa False na True, stavite danasnji datum za datum uzimanja i datum vracanja knjige!");
            IzmeniPodatkeForma forma = new IzmeniPodatkeForma(korisnik);
            Refresh();
            forma.ShowDialog();
            Refresh();

            List<Knjiga> pomLista = new List<Knjiga>();
            pomLista = korisnik.ListaZelja;
            foreach (Knjiga k in korisnik.ListaZelja.ToArray())
            {
                if (k.Naslov == knjiga.Naslov)
                {
                    pomLista.Remove(k);

                }
            }
            int broj = knjiga.BrojPrimeraka;
            int noviBr = broj + 1;
            var update3 = Builders<Knjiga>.Update.Set("BrojPrimeraka", noviBr);
            var rez3 = collectionK.FindOneAndUpdate(filter, update3);
            Refresh();
            var update2 = Builders<Korisnik>.Update.Set("ListaZelja", pomLista);
            var rez2 = collectionKorisnik.FindOneAndUpdate(filter2, update2);
           
            popuniPodacima();
            Refresh();
            MessageBox.Show("Uklonili ste je i iz liste zelja!");
            btnIznajmi.Enabled = true;
            btnVrati.Enabled = false;


        }
    }
}
