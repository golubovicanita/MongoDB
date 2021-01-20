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
using MongoDB.Driver.Linq;
using MongoDB.Driver.GeoJsonObjectModel;
using MongoDB.Driver.Core;
using Nest;
using MongoDB.Driver.Builders;

namespace Biblioteka_MongoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnInformacije_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collection = db.GetCollection<Biblioteka>("biblioteka");

            /*ZA TESTRIRANJE
             * 
             *  Biblioteka biblioteka = new Biblioteka { Naziv = "Stevan Sremac", Adresa = "Borivoja Gojkovica 9", Telefon = new List<string> { " 018/511-403", "018 / 250 - 188" }, GodinaOsnivanja = 1879, GodisnjaClanarina = 800 };
                collection.InsertOne(biblioteka);
             */
            var query1 = from b in collection.AsQueryable<Biblioteka>()
                         where b.Naziv == "Stevan Sremac"
                         select b;
            foreach (Biblioteka bb in query1)
            {
                if (bb == null)
                {
                    Biblioteka biblioteka = new Biblioteka { Naziv = "Stevan Sremac", Adresa = "Borivoja Gojkovica 9", Telefon = new List<string> { " 018/511-403", "018 / 250 - 188" }, GodinaOsnivanja = 1879, GodisnjaClanarina = 800 };
                    collection.InsertOne(biblioteka);
                }
                PrikaziInfoBiblioteka forma = new PrikaziInfoBiblioteka(bb);
                Refresh();
                forma.ShowDialog();
            }
            
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
                DonirajKnjiguForma forma = new DonirajKnjiguForma();
                Refresh();
                forma.ShowDialog();
        }

        private void btnNaslov_Click(object sender, EventArgs e)
        {
            string autor = this.txtAutor.Text;
            string naslov = this.txtNaslov.Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collection = db.GetCollection<Knjiga>("knjige");

            var query1 = from k in collection.AsQueryable<Knjiga>()
                         where (k.Naslov==naslov && k.Autor==autor) && k.BrojPrimeraka >0
                         select k;
            List<Knjiga> pomList = new List<Knjiga>();
            foreach (Knjiga k in query1)
            {
                pomList.Add(k);
            }
            if (pomList.Count == 0)
            {
                MessageBox.Show("Nema rezultata.");
            }
            else
            {
                PrikaziIzabraneKnjige forma = new PrikaziIzabraneKnjige(pomList);
                Refresh();
                forma.ShowDialog();
                
            }

        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            string autor = this.txtAutorOR.Text;
            string naslov = this.txtNaslovOR.Text;

            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collection = db.GetCollection<Knjiga>("knjige");

            var query1 = from k in collection.AsQueryable<Knjiga>()
                         where (k.Naslov == naslov | k.Autor == autor) && k.BrojPrimeraka > 0
                         select k;
            List<Knjiga> pomList = new List<Knjiga>();
            foreach (Knjiga k in query1)
            {
                pomList.Add(k);
            }
            if (pomList.Count == 0)
            {
                MessageBox.Show("Nema rezultata.");
            }
            else
            {
                PrikaziIzabraneKnjige forma = new PrikaziIzabraneKnjige(pomList);
                forma.ShowDialog();
                Refresh();
            }
        }
    }
}
