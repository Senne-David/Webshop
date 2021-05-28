using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_domain.Business
{
    public class Product
    {
        //velden 
        private int _id;
        private string _productnaam;
        private string _productcategorie;
        private string _omschrijving;
        private double _prijs;

        //eigenschappen
        public int ID
        {
            get { return _id; }
        }
        public string ProductNaam
        {
            get { return _productnaam ; }
            set { _productnaam = value; }
        }
        public string ProductCategorie
        {
            get { return _productcategorie; }
            set { _productcategorie = value; }
        }
        public string Omschrijving
        {
            get { return _omschrijving; }
            set { _omschrijving = value; }
        }
        public double Prijs
        {
            get { return _prijs; }
            set { _prijs = value; }
        }
        //Contructor
        public Product(int id, string productnaam, string productcategorie, string omschrijving, double prijs)
        {
            _id = id;
            _productnaam = productnaam;
            _productcategorie = productcategorie;
            _omschrijving = omschrijving;
            _prijs = prijs;
        }
        public Product(string productnaam, string productcategorie, string omschrijving, double prijs)
        {
            _id = 0;
            _productnaam = productnaam;
            _productcategorie = productcategorie;
            _omschrijving = omschrijving;
            _prijs = prijs;
        }
        public override string ToString()
        {
            return _id + " - " + _productnaam + " - " + _productcategorie + " - " + _omschrijving + " - " + _prijs + " euro";
        }
    }
}
