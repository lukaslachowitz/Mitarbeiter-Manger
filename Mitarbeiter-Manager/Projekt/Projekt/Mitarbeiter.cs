using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Mitarbeiter
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public string Anrede { get; set; }
        public string Telefonnummer { get; set; }
        public string Ort { get; set; }
        public DateTime Geburtsdatum { get; set; }
        public string Abteilung { get; set; }
        public string Adresse { get; set; }
        public string Adresszusatz{ get; set; }
        public double SZ { get; set; }
        public string IBAN { get; set; }

        public Mitarbeiter(string vn, string nn, string anrede, string tel, string ort, DateTime geb, string abteilung, string adresse, string adresszu, double sz, string iban)
        {
            this.Vorname = vn;
            this.Nachname = nn;
            this.Anrede = anrede;
            this.Telefonnummer = tel;
            this.Ort = ort;
            this.Geburtsdatum = geb;
            this.Abteilung = abteilung;
            this.Adresse = adresse;
            this.Adresszusatz = adresszu;
            this.SZ = sz;
            this.IBAN = iban;
        }

    }
    
}
