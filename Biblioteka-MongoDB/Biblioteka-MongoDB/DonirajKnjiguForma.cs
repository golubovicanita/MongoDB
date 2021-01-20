using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
namespace Biblioteka_MongoDB
{
    public partial class DonirajKnjiguForma : Form
    {
        public DonirajKnjiguForma()
        {
            InitializeComponent();
        }

        private void btnDoniraj_Click(object sender, EventArgs e)
        {
            var connectionString = "mongodb://localhost/?safe=true";
            var client = new MongoClient(connectionString);
            var db = client.GetDatabase("StevanSremac");

            var collectionKnjige = db.GetCollection<Knjiga>("knjige");
            var collectionBiblioteka = db.GetCollection<Biblioteka>("biblioteka");

            var query1 = from b in collectionBiblioteka.AsQueryable<Biblioteka>()
                         where b.Naziv == "Stevan Sremac"
                         select b;
             int brojP = Int32.Parse(txtBroj.Text);
             List<MongoDBRef> pomLista = new List<MongoDBRef>();
            foreach (Biblioteka bb in query1)
            {
                Knjiga doniranaK = new Knjiga { Naslov = txtNaslov.Text, Autor = txtAutor.Text, Zanr = txtZanr.Text, GodinaIzdavanja = txtGod.Text, BrojPrimeraka = brojP, Biblioteka = new MongoDBRef("biblioteka", bb.Id) };
                collectionKnjige.InsertOne(doniranaK);
                pomLista = bb.Knjige;
                pomLista.Add(new MongoDBRef("knjige", doniranaK.Id));

                var filter = new BsonDocument("Naziv", "Stevan Sremac");
                var update = Builders<Biblioteka>.Update.Set("Knjige", pomLista);
                var rez = collectionBiblioteka.FindOneAndUpdate(filter, update);
                
            }
            MessageBox.Show("Uspesno ste donirali knjigu. Hvala na donaciji!");
            Close();
            
        }
    }
}
