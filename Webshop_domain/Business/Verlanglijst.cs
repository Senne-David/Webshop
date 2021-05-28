using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_domain.Business
{
    public class Verlanglijst
    {
        //velden 
        private int _id;
        private int _fkProduct;
        private string _productnaam;
        private int _fkKlant;

        //eigenschappen
        public int ID
        {
            get { return _id; }
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
        public int FKklant
        {
            get { return _fkKlant; }
            set { _fkKlant = value; }
        }
        //Contructor
        public Verlanglijst(int id, int fkProduct, string productnaam, int fkKlant)
        {
            _id = id;
            _fkProduct = fkProduct;
            _productnaam = productnaam;
            _fkKlant = fkKlant;
        }
        public Verlanglijst(int fkProduct, string productnaam,  int fkKlant)
        {
            _id = 0;
            _fkProduct = fkProduct;
            //_productnaam = productnaam;
            _fkKlant = fkKlant;
        }

        public override string ToString()
        {
            return "product: " + _productnaam;
        }
    }
}
