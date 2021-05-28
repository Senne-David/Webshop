using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_domain.Business
{
    public class Winkelwagen_has_Producten
    {
        //velden 
        private int _id;
        private int _aantal;
        private int _fkProduct;
        private string _productnaam;
        private double _productprijs;
        private int _fkWinkelwagen;

        //eigenschappen
        public int ID
        {
            get { return _id; }
        }
        public int Aantal
        {
            get { return _aantal; }
            set { _aantal = value; }
        }
        public int FKProduct
        {
            get { return _fkProduct; }
            set { _fkProduct = value; }
        }
        public string Productnaam
        {
            get { return _productnaam; }
            set { _productnaam = value; }
        }
        private double Prijsproduct
        {
            get { return _productprijs; }
            set { _productprijs = value; }
        }
        public int FkWinkelwagen
        {
            get { return _fkWinkelwagen; }
            set { _fkWinkelwagen = value; }
        }
        //Contructor
        public Winkelwagen_has_Producten(int id, int aantal, int fkProduct, string productnaam, double prijs, int fkWinkelwagen)
        {
            _id = id;
            _aantal = aantal;
            _fkProduct = fkProduct;
            _productnaam = productnaam;
            _productprijs = prijs;
            _fkWinkelwagen = fkWinkelwagen;
        }
        public Winkelwagen_has_Producten(int aantal, int fkProduct, int fkWinkelwagen)
        {
            _id = 0;
            _aantal = aantal;
            _fkProduct = fkProduct;
            _fkWinkelwagen = fkWinkelwagen;
        }

        public override string ToString()
        {
            return _productnaam + " - aantal: " + _aantal + " - prijs: " + _productprijs + " euro";
            //return _id + " - " + _fkProduct + " - " + _fkWinkelwagen;
        }
    }
}
