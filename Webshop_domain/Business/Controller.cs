using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webshop_domain.Persisance;

namespace Webshop_domain.Business
{
    public class Controller
    {
        //Velden
        private Persisance.Controller _persistController;
        private Klant _AangemeldeKlant;
        private Winkelwagen _actieveWinkelwagen;

        //Contructor
        public Controller()
        {
            _persistController = new Persisance.Controller();
        }
        public Controller(string conn)
        {
            _persistController = new Persisance.Controller(conn);
        }

        //Methods



        //Controlleren of er al een winkelwagen is aangemaakt
        public bool CheckWinkelwagen()
        {
            if (_actieveWinkelwagen == null)
            {
                return false;
            }
            return true;
        }



        //Klant

        //Lijst van alle klanten ophalen
        public List<Klant> getKlant()
        {
            return _persistController.getKlant();
        }
        //Login
        public bool CheckKlant(string naam, string paswoord)
        {
            _AangemeldeKlant = _persistController.SearchKlant(naam, paswoord);
            if (_AangemeldeKlant == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        //Klant toevoegen
        public bool addKlant(string gebruikersnaam, string paswoord, string voornaam, string achternaam, string geboortedatum, int postcode, string straat, int huisnummer, string email, string telefoon)
        {
            return _persistController.addKlant(gebruikersnaam, paswoord, voornaam, achternaam, geboortedatum, postcode, straat, huisnummer, email, telefoon);
        }



        //Product

        //Lijst met Producten ophalen
        public List<Product> getProduct()
        {
            return _persistController.getProduct();
        }
        //Producten teovoegen
        public void addProduct(Product item)
        {
            _persistController.addProduct(item);
        }
        //Producten verwijderen
        public bool DeleteProductFromList(int index)
        {
            Product product = _persistController.getProduct()[index];
            return _persistController.DeleteProduct(product.ID);
        }



        //Verlanglijstje

        //Persoonlijke Verlanglijstje opvragen
        public List<Verlanglijst> getVerlanglijstje()
        {
            return _persistController.getVerlanglijstje(_AangemeldeKlant.ID);
        }
        //Toevoegen aan Verlanglijstje
        public bool addVerlanglijstje(int index)
        {
            Product item = _persistController.getProduct()[index];
            return _persistController.AddToVerlanglijstje(item.ID, _AangemeldeKlant.ID);
        }
        //Producten verwijderen uit je verlanglijstje
        public bool DeleteItemFromVerlanglijst(int index)
        {
            Verlanglijst verlanglist = _persistController.getVerlanglijstje(_AangemeldeKlant.ID)[index];
            return _persistController.DeleteVerlanglijst(verlanglist.ID);
        }



        //Winkelwagen

        //Bestellingen ophalen
        public List<Winkelwagen> getBestellingen()
        {
            return _persistController.getAfgerekendeWinkelwagens();
        }
        //Winkelwagen toevoegen
        public bool addWinkelwagen(string datum, int verzendkosten, string kaartnummer, string verzendmethode, int afgerekend)
        {
            try
            {
                _actieveWinkelwagen = new Winkelwagen(datum, verzendkosten, kaartnummer, verzendmethode, _AangemeldeKlant.ID, afgerekend);
                _actieveWinkelwagen.ID = _persistController.addWinkelwagen(_actieveWinkelwagen);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Winkelwagen status updaten naar afgerekend
        public bool UpdateActieveWinkelwagen()
        {
            return _persistController.UpdateWinkelwagen(_actieveWinkelwagen.ID);
        }



        //WinkelwagenHasProducten

        //Producten in je winkelwagen ophalen
        public List<Winkelwagen_has_Producten> getWinkelwagenHasProducten()
        {
            return _persistController.getWinkalwagen_has_Producten(_actieveWinkelwagen.ID);
        }
        //De Producten van een Bestelling ophalen
        public List<Winkelwagen_has_Producten> getProductenVanBestelling(int WinkelwagenID)
        {
            return _persistController.getWinkalwagen_has_Producten(WinkelwagenID);
        }
        //Producten toevoegen aan Winkelwagen
        public bool addToWinkelwagentje(int index, int aantal)
        {
            Product product = _persistController.getProduct()[index];
            return _persistController.AddToWinkelwagen(_actieveWinkelwagen.ID, product.ID, aantal);
        }
        //Producten verwijderen uit Winkelwagen
        public bool DeleteItemFromWinkelwagen_Has_Producten(int index)
        {
            Winkelwagen_has_Producten winkelwagenproduct = _persistController.getWinkalwagen_has_Producten(_actieveWinkelwagen.ID)[index];
            return _persistController.DeleteWinkelwagenItem(winkelwagenproduct.ID);
        }
        //Totaal Winkelwagen opvragen
        public double getTotaal()
        {
            return _persistController.getAfrekening(_actieveWinkelwagen.ID);
        }
    }

}
