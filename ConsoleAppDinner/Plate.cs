using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDinner
{
    public class Plate
    {
        
        // data
        public string PlateName { get; set; }
        public decimal Price { get; set; }
        public int PlateNumber { get; set; }


        // constructors
        public Plate() { }

        public Plate(string ordernumber)
        {
            switch (ordernumber)
            {
                case "1": 
                    {
                        this.PlateNumber = 1;
                        this.PlateName = "Burger Platter";
                        this.Price = 4.99M;
                        break;
                    }

                case "2":
                    {
                        this.PlateNumber = 2;
                        this.PlateName = "Taco Platter";
                        this.Price = 3.59M;
                        break;
                    }

                case "3":
                    {
                        this.PlateNumber = 3;
                        this.PlateName = "Pasta Platter"; 
                        this.Price = 6.99M;
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
