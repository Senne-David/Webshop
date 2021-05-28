using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshop_domain.Business
{
    class Totaal
    {
        //velden 
        private int _id;
        private double _totaal;

        //eigenschappen
        public int ID
        {
            get { return _id; }
        }
        public double Afrekening
        {
            get { return _totaal; }
            set { _totaal = value; }
            
        }
        
        //Contructor
        public Totaal(int id, double totaal)
        {
            _id = id;
            _totaal = totaal;
        }
        public Totaal(double totaal)
        {
            _id = 0;
            _totaal = totaal;
        }

        public override string ToString()
        {
            return Convert.ToString(_totaal);
        }
    }
}
