using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Biblioteka_MongoDB
{
    public class Biblioteka
    {
        public ObjectId Id { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public List<string> Telefon { get; set; }
        public int GodinaOsnivanja { get; set; }
        public float GodisnjaClanarina { get; set; }
        public List<MongoDBRef> Knjige { get; set; }//knjige koje se nalaze u biblioteci
        public Biblioteka()
        {
            Knjige = new List<MongoDBRef>();
        }

    }
}
