using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_domain.Business;

namespace Webshop_domain.Persisance
{
    class Controller
    {
        //Velden
        private string _connectionstring;

        //Constructors
        public Controller()
        {
            _connectionstring = "server = localhost; user id = root;password=1234; database=webshop_database";
        }
        public Controller(string conn)
        {
            _connectionstring = conn;
        }



        // Klant

        //Inloggen
        public Klant SearchKlant(string naam, string paswoord)
        {
            Klant_Mapper mapper = new Klant_Mapper();
            return mapper.SearchKlantInDB(_connectionstring, naam, paswoord);
        }
        //Alle klanten opvragen
        public List<Klant> getKlant()
        {
            Klant_Mapper klantmapper = new Klant_Mapper();
            return klantmapper.getKlantFromDB(_connectionstring);
        }
        //Klant toevoegen
        public bool addKlant(string gebruikersnaam, string paswoord, string voornaam, string achternaam, string geboortedatum, int postcode, string straat, int huisnummer, string email, string telefoon)
        {
            Klant_Mapper klantmapper = new Klant_Mapper();
            return klantmapper.addKlantToDB(_connectionstring, gebruikersnaam, paswoord, voornaam, achternaam, geboortedatum, postcode, straat, huisnummer, email, telefoon);
        }



        //Product

        //Producten opvragen
        public List<Product> getProduct()
        {
            Product_Mapper productmapper = new Product_Mapper();
            return productmapper.getProductFromDB(_connectionstring);
        }
        //Product toevoegen
        public void addProduct(Product item)
        {
            Product_Mapper productmapper = new Product_Mapper();
            productmapper.addProductToDB(_connectionstring, item);
        }
        //Product verwijderen
        public bool DeleteProduct(int idproduct)
        {
            Product_Mapper productmapper = new Product_Mapper();
            return productmapper.DeleteFromProductenInDB(_connectionstring, idproduct);
        }



        //Verlanglijstje

        //Persoonlijke Verlanglijst opvragen
        public List<Verlanglijst> getVerlanglijstje(int idklant)
        {
            Verlanglijstje_Mapper verlanglijstjemapper = new Verlanglijstje_Mapper();
            return verlanglijstjemapper.getVerlanglijstjeFromDB(_connectionstring, idklant);
        }
        //Algemene verlanglijst opvragen
        public List<Verlanglijst> getAlgemeneVerlanglijst()
        {
            Verlanglijstje_Mapper mapper = new Verlanglijstje_Mapper();
            return mapper.getAlgemeneVerlanglijst(_connectionstring);
        }
        //Product toevoegen aan Verlanglijstje
        public bool AddToVerlanglijstje(int idProduct, int idKlant)
        {
            Verlanglijstje_Mapper mapper = new Verlanglijstje_Mapper();
            return mapper.addVerlanglijstjeToDB(_connectionstring, idProduct, idKlant);
        }
        //Producten verwijderen uit Verlanglijstje
        public bool DeleteVerlanglijst(int idverlanglijstitem)
        {
            Verlanglijstje_Mapper verlanglijstjemapper = new Verlanglijstje_Mapper();
            return verlanglijstjemapper.DeleteFromVerlanglijstjeInDB(_connectionstring, idverlanglijstitem);
        }



        //Winkelwagen

        //Afgerekende winkelwagens opvragen
        public List<Winkelwagen> getAfgerekendeWinkelwagens()
        {
            Winkelwagen_Mapper winkelwagenmapper = new Winkelwagen_Mapper();
            return winkelwagenmapper.getAfgerekendeMandjesFromDB(_connectionstring);
        }
        //Winkelwagen Aanmaken
        public int addWinkelwagen(Winkelwagen item)
        {
            Winkelwagen_Mapper winkelwagenmapper = new Winkelwagen_Mapper();
            return winkelwagenmapper.addWinkelwagenToDB(_connectionstring, item);
        }
        //Status Winkelwagen veranderen naar afgerekend
        public bool UpdateWinkelwagen(int idActieveWinkelwagen)
        {
            Winkelwagen_Mapper winkelwagenmapper = new Winkelwagen_Mapper();
            return winkelwagenmapper.UpdateWinkelwagenInDB(_connectionstring, idActieveWinkelwagen);
        }



        //WinkelwagenhasProducten

        //Persoonlijke Winkelwagen en producten opvragen
        public List<Winkelwagen_has_Producten> getWinkalwagen_has_Producten(int idwinkelwagen)
        {
            Winkelwagen_has_Producten_Mapper winkelwagenhasProductenmapper = new Winkelwagen_has_Producten_Mapper();
            return winkelwagenhasProductenmapper.getWinkelwagen_has_ProductFromDB(_connectionstring, idwinkelwagen);
        }
        //producten toevegen aan winkelwagen
        public bool AddToWinkelwagen(int idwinkelwagen, int idproduct, int aantal)
        {
            Winkelwagen_has_Producten_Mapper mapper = new Winkelwagen_has_Producten_Mapper();
            return mapper.addWinkalwagen_has_ProductenToDB(_connectionstring, idwinkelwagen, aantal, idproduct);
        }
        //Producten verwijderen uit winkelwagen
        public bool DeleteWinkelwagenItem(int idwinkelwagenitem)
        {
            Winkelwagen_has_Producten_Mapper winkelwagenitemmapper = new Winkelwagen_has_Producten_Mapper();
            return winkelwagenitemmapper.DeleteFromWinkelwagenInDB(_connectionstring, idwinkelwagenitem);
        }
        //Totaal Winkelwagen opvragen
        public double getAfrekening(int idwinkelwagen)
        {
            Winkelwagen_has_Producten_Mapper winkelwagenhasProductenmapper = new Winkelwagen_has_Producten_Mapper();
            return winkelwagenhasProductenmapper.getTotaalFromDB(_connectionstring, idwinkelwagen);
        }
    }
}
