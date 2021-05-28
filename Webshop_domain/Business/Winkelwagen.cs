using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_domain.Business
{
    public class Winkelwagen
    {
        //velden 
        private int _id;
        private string _datum;
        private double _verzendkosten;
        private string _kaartnummer;
        private string _verzendmethode;
        private int _fkKlant;
        private string _gebruikersnaam;
        private int _afgerekend;
        //eigenschappen
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Datum
        {
            get { return _datum; }
            set { _datum = value; }
        }
        public double Verzendkosten
        {
            get { return _verzendkosten; }
            set { _verzendkosten = value; }
        }
        public string Kaartnummer
        {
            get { return _kaartnummer; }
            set { _kaartnummer = value; }
        }
        public string Verzendmethode
        {
            get { return _verzendmethode; }
            set { _verzendmethode = value; }
        }
        public int FKklant
        {
            get { return _fkKlant; }
            set { _fkKlant = value; }
        }
        public string Gebruikersnaam
        {
            get { return _gebruikersnaam; }
            set { value = _gebruikersnaam; }
        }
        public int Afgerekend
        {
            get { return _afgerekend; }
            set { _afgerekend = value; }
        }
        //Contructor
        public Winkelwagen(int id, string datum, double verzendkosten, string kaartnummer, string verzendmethode, int fkKlant, string gebruikersnaam, int afgerekend)
        {
            _id = id;
            _datum = datum;
            _verzendkosten = verzendkosten;
            _kaartnummer = kaartnummer;
            _verzendmethode = verzendmethode;
            _fkKlant = fkKlant;
            _gebruikersnaam = gebruikersnaam;
            _afgerekend = afgerekend;
        }
        public Winkelwagen(string datum, double verzendkosten, string kaartnummer, string verzendmethode, int fkKlant, int afgerekend)
        {
            _id = 0;
            _datum = datum;
            _verzendkosten = verzendkosten;
            _kaartnummer = kaartnummer;
            _verzendmethode = verzendmethode;
            _fkKlant = fkKlant;
            _afgerekend = afgerekend;
        }
        public override string ToString()
        {
            return _id + " - " + _datum + " - " + _verzendkosten + " - " + _kaartnummer + " - " + _verzendmethode + " - " + _fkKlant + " " + _gebruikersnaam;
        }
    }
}
