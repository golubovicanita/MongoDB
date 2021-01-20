using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
namespace Biblioteka_MongoDB
{
    public class Knjiga
    {
        public ObjectId Id { get; set; }
        public string Naslov { get; set; }// kasnije se vrsi pretrazivanje i/ili po naslovu i/ili autoru
        public string  Autor { get; set; }
        public string Zanr { get; set; }
        public string GodinaIzdavanja { get; set; }
        public int BrojPrimeraka { get; set; }
        public MongoDBRef Biblioteka { get; set; }// ref ka dokumentu Biblioteka gde se nalazi knjiga
        public List<MongoDBRef> Korisnici { get; set; }// veza 1:N zbog broja primeraka, jednu knjigu moze da iznajmi vise korisnika

        public Knjiga()
        {
            Korisnici = new List<MongoDBRef>();
        }
    }
}
