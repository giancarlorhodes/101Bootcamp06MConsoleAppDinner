using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDinner
{
    class Order
    {

        // data
        public List<Plate> ListOfPlates { get; set; }

        // constructors
        public Order() {

            this.ListOfPlates = new List<Plate>();
        }

        const decimal _tax = .0725M;

        // methods
        public decimal SubTotal() 
        {

            decimal subtotal = 0;

            foreach  (Plate _p in ListOfPlates)
            {
                subtotal = subtotal + _p.Price;
            }

            return subtotal;
        }

        public decimal Tip()
        {
            decimal tip = 0;

            foreach (Plate _p in ListOfPlates)
            {
                tip = tip + _p.Price;
            }

            return tip * .2M;
        }

        public decimal Tax()
        {

            decimal _value = 0;
            foreach (Plate _p in ListOfPlates)
            {
                _value = _value + _p.Price;
            }
            return _value * _tax;
        }

        public decimal Total() 
        {
            return this.SubTotal() + this.Tip() + this.Tax();
        }
    }
}
