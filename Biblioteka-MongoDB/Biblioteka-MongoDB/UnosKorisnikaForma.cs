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

namespace Biblioteka_MongoDB
{
    public partial class UnosKorisnikaForma : Form
    {
        public UnosKorisnikaForma()
        {
            InitializeComponent();
        }

        private void btnAddKorisnik_Click(object sender, EventArgs e)
        {
            string ime = txtIme.Text;
            string prezime = txtPrezime.Text;
            string jmbg = txtJMBG.Text;
            string adresa = txtAdresa.Text;
            string telefon = txtTelefon.Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collection = db.GetCollection<Korisnik>("korisnici");
            Korisnik k = new Korisnik { Ime = ime, Prezime = prezime, JMBG = jmbg, Adresa = adresa, Telefon = telefon, VratioKnjigu= true, DatumUzimanja= DateTime.Now,  RokZaVracanje= DateTime.Now};
            collection.InsertOne(k);
            MessageBox.Show("Uspesno ste dodali korisnika: "+ ime + " " + prezime);
            Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
