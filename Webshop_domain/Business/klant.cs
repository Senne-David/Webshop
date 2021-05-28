using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_domain.Business
{
    public class Klant
    {
        //velden 
        private int _id;
        private string _gebruikersnaam;
        private string _paswoord;
        private string _voornaam;
        private string _achternaam;
        private string _geboortedatum;
        private int _postcode;
        private string _straat;
        private int _huisnummer;
        private string _email;
        private string _telefoonnummer;

        //eigenschappen
        public int ID
        {
            get { return _id; }
        }
        public string Gebruikersnaam
        {
            get { return _gebruikersnaam; }
            set { _gebruikersnaam = value; }
        }
        public string Paswoord
        {
            get { return _paswoord; }
            set { _paswoord = value; }
        }
        public string Voornaam
        {
            get { return _voornaam; }
            set { _voornaam = value; }
        }
        public string Achternaam
        {
            get { return _achternaam; }
            set { _achternaam = value; }
        }
        public string Geboortedatum
        {
            get { return _geboortedatum; }
            set { _geboortedatum = value; }
        }
        public int Postcode
        {
            get { return _postcode; }
            set { _postcode = value; }
        }
        public string Straat
        {
            get { return _straat; }
            set { _straat = value; }
        }
        public int Huisnummer
        {
            get { return _huisnummer; }
            set { _huisnummer = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Telefoonnummer
        {
            get { return _telefoonnummer; }
            set { _telefoonnummer = value; }
        }
        //Contructor
        public Klant(int id, string gebruikersnaam, string paswoord, string voornaam, string achternaam, string geboortedatum, int postcode, string straat, int huisnummer, string email, string telefoonnummer)
        {
            _id = id;
            _gebruikersnaam = gebruikersnaam;
            _paswoord = paswoord;
            _voornaam = voornaam;
            _achternaam = achternaam;
            _geboortedatum = geboortedatum;
            _postcode = postcode;
            _straat = straat;
            _huisnummer = huisnummer;
            _email = email;
            _telefoonnummer = telefoonnummer;
        }
        public Klant(string gebruikersnaam, string paswoord, string voornaam, string achternaam, string geboortedatum, int postcode, string straat, int huisnummer, string email, string telefoonnummer)
        {
            _id = 0;
            _gebruikersnaam = gebruikersnaam;
            _paswoord = paswoord;
            _voornaam = voornaam;
            _achternaam = achternaam;
            _geboortedatum = geboortedatum;
            _postcode = postcode;
            _straat = straat;
            _huisnummer = huisnummer;
            _email = email;
            _telefoonnummer = telefoonnummer;
        }
        public override string ToString()
        {
            return _id + " - " + _gebruikersnaam + " - " + _voornaam + " " + _achternaam + " - " + _geboortedatum + " - " + _postcode + " " + _straat + " " + _huisnummer + " - " + _email + " - " + _telefoonnummer;
        }
    }
}
