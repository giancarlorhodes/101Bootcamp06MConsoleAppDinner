using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDinner
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // step 1 - print basic instruction and get customer info
            Console.WriteLine("Please enter the customer name for this food order");
            string _name = Console.ReadLine();
            Customer customer = new Customer() { CustomerName = _name };

            // step 2 - print out menu choices
            Console.WriteLine("Thanks " + _name + ". Here is the menu.");
            Menu _m = new Menu();           
            foreach (Plate item in _m.PossiblePlates)
            {
                Console.WriteLine("Item #: {0}, Plate Name: {1}, Price: {2}", item.PlateNumber, 
                    item.PlateName, item.Price);
            }

            // step 3 loop for taking orders
            Order _o = new Order(); // Order is my main workhorse class
            Console.WriteLine("Enter Item # or s to stop ordering");
            string ordernumber = Console.ReadLine();           
            bool IsOrdering = true;
            if (ordernumber.ToUpper() == "S") { IsOrdering = false; } // could be S first thing
            while (IsOrdering)
            {
                // each time the enter item #, add it to Orders
                if (ordernumber.ToUpper() == "S")
                {
                    IsOrdering = false;
                }
                else if (Convert.ToInt32(ordernumber) == (int)MenuItem.Burger) 
                {
                    Plate _p = new Plate(ordernumber);
                    _o.ListOfPlates.Add(_p);
                    Console.WriteLine("Enter another Item # or s to stop ordering");
                    ordernumber = Console.ReadLine();
                }
                else if (Convert.ToInt32(ordernumber) == (int)MenuItem.Taco)
                {
                    Plate _p = new Plate(ordernumber);
                    _o.ListOfPlates.Add(_p);
                    Console.WriteLine("Enter another Item # or s to stop ordering");
                    ordernumber = Console.ReadLine();
                }
                else if (Convert.ToInt32(ordernumber) == (int)MenuItem.Pasta)
                {
                    Plate _p = new Plate(ordernumber);
                    _o.ListOfPlates.Add(_p);
                    Console.WriteLine("Enter another Item # or s to stop ordering");
                    ordernumber = Console.ReadLine();
                }                
            }


            // TODO: output the calculations
            Console.WriteLine(_name + ", your subtotal is: " + _o.SubTotal());
            Console.WriteLine(_name + ", your tax is: " + _o.Tax());
            Console.WriteLine(_name + ", your tip is: " + _o.Tip());
            Console.WriteLine(_name + ", your total is: " + _o.Total());

            // final messaging
            Console.WriteLine("Thanks for your patronage " + _name + "!!!");
            Console.ReadKey(); // stopping the program
        }
    }
}
