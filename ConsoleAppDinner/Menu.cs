using System.Collections.Generic;

namespace ConsoleAppDinner
{
    class Menu 
    { 
    
        public List<Plate> PossiblePlates { get; set;  }

        public Menu()
        {

            PossiblePlates = new List<Plate>();
            PossiblePlates.Add(new Plate { PlateNumber = 1, PlateName = "Burger Platter", Price = 4.99M });
            PossiblePlates.Add(new Plate { PlateNumber = 2, PlateName = "Taco Platter", Price = 3.59M });
            PossiblePlates.Add(new Plate { PlateNumber = 3, PlateName = "Pasta Platter", Price = 6.99M });
        }
    
    }
}
