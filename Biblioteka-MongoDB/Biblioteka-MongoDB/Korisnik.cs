using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Biblioteka_MongoDB
{
    public class Korisnik
    {
        public ObjectId Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public List<Knjiga> ListaZelja { get; set; }// koje bi sve knjige zeleo da iznajmi, iz liste knjiga bira koju ce da iznajmi
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime DatumUzimanja { get; set; }//prilikom doavanja novog korisnika, stavlja se danasnji datum 
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime RokZaVracanje { get; set; }//prilikom doavanja novog korisnika, stavlja se danasnji datum 
        public bool VratioKnjigu { get; set; }
        public MongoDBRef Knjiga { get; set; }// ref na dokument Knjiga koji je korisnik trenutno iznajmio(sme samo jednu)
        public Korisnik()
        {
            ListaZelja = new List<Knjiga>();
        }
    }
}
