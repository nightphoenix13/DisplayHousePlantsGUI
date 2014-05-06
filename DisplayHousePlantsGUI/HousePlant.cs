using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisplayHousePlantsGUI
{
    class HousePlant
    {
        // class attributes
        private string name;
        private double price;
        private bool fed;

        // constructor
        public HousePlant(string n, double p, bool f)
        {
            setClass(n, p, f);
        } // constructor end

        // properties
        public string Name {get; set;} // Name property end
        public double Price
        {
            get
            {
                return price;
            } // end get
            set
            {
                if (value > 0.0)
                {
                    price = value;
                } // end if
                else
                {
                    price = 0.0;
                } // end else
            } // end set
        } // Price property end
        public bool Fed {get; set;} // Fed property end

        // class set method
        private void setClass(string n, double p, bool f)
        {
            Name = n;
            Price = p;
            Fed = f;
        } // class set method end
    } // HousePlant class end
}
