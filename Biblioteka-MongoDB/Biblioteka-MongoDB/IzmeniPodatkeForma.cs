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
    public partial class IzmeniPodatkeForma : Form
    {
        Korisnik korisnik;
        public IzmeniPodatkeForma()
        {
            InitializeComponent();
        }
        public IzmeniPodatkeForma(Korisnik k)
        {
            InitializeComponent();
            korisnik = k;
            txtIme.Text = korisnik.Ime;
            txtPrezime.Text = korisnik.Prezime;
            txtJMBG.Text = korisnik.JMBG;
            txtTelefon.Text = korisnik.Telefon;
            this.dateTimeUzeo.Text = korisnik.DatumUzimanja.ToShortDateString();
            txtVratioKnjigu.Text = korisnik.VratioKnjigu.ToString();
            this.dateTimeVratio.Text = korisnik.RokZaVracanje.ToShortDateString();
            txtAdresa.Text = korisnik.Adresa;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionKnjige = db.GetCollection<Knjiga>("knjige");
            var collectionKorisnik = db.GetCollection<Korisnik>("korisnici");

            if (txtIme.Text != korisnik.Ime)
            {
                var filter = new BsonDocument("JMBG", korisnik.JMBG);
                var update = Builders<Korisnik>.Update.Set("Ime", txtIme.Text);
                var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
                MessageBox.Show("Promenili ste ime!");
            }
            if(txtPrezime.Text!= korisnik.Prezime)
            {
                var filter = new BsonDocument("JMBG", korisnik.JMBG);
                var update = Builders<Korisnik>.Update.Set("Prezime", txtPrezime.Text);
                var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
                MessageBox.Show("Promenili ste prezime!");
            }
            if(txtJMBG.Text != korisnik.JMBG)
            {
                var filter = new BsonDocument("JMBG", korisnik.JMBG);
                var update = Builders<Korisnik>.Update.Set("JMBG", txtJMBG.Text);
                var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
                MessageBox.Show("Promenili ste maticni broj!");
            }
            if(txtTelefon.Text != korisnik.Telefon)
            {
                var filter = new BsonDocument("JMBG", korisnik.JMBG);
                var update = Builders<Korisnik>.Update.Set("Telefon", txtTelefon.Text);
                var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
                MessageBox.Show("Promenili ste broj telefona!");
            }
            if (txtAdresa.Text != korisnik.Adresa)
            {
                var filter = new BsonDocument("JMBG", korisnik.JMBG);
                var update = Builders<Korisnik>.Update.Set("Adresa", txtAdresa.Text);
                var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
                MessageBox.Show("Promenili ste adresu!");
            }
            if(this.dateTimeUzeo.Value != korisnik.DatumUzimanja)
            {
                var filter = new BsonDocument("JMBG", korisnik.JMBG);
                var update = Builders<Korisnik>.Update.Set("DatumUzimanja", this.dateTimeUzeo.Value.ToShortDateString());
                var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
                MessageBox.Show("Promenili ste datum uzimanja knjige!");
            }
            bool vratioo = Boolean.Parse(txtVratioKnjigu.Text);
            if ( vratioo != korisnik.VratioKnjigu)
            {
                var filter = new BsonDocument("JMBG", korisnik.JMBG);
                var update = Builders<Korisnik>.Update.Set("VratioKnjigu", vratioo);
                var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
                MessageBox.Show("Promenili ste da li je knjiga vracena!");
            }
            if(this.dateTimeVratio.Value!= korisnik.RokZaVracanje)
            {
                var filter = new BsonDocument("JMBG", korisnik.JMBG);
                var update = Builders<Korisnik>.Update.Set("RokZaVracanje", this.dateTimeVratio.Value.ToShortDateString());
                var rez = collectionKorisnik.FindOneAndUpdate(filter, update);
                MessageBox.Show("Promenili ste rok za vracanje knjige!");
            }
            Refresh();
            Close();
        }
    }
}
