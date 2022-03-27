using System;
using System.Collections.Generic;

namespace Guiter
{

  
class Program
    {
        static void Main(string[] args)
        {

     
            Inventory inventory = new Inventory();
            initializeInventory(inventory);
            
            GuitarSpec whatErinLikes = new GuitarSpec( Builder.Fender, "Stratocastor",
              Types.ELECTRIC, Wood.ALDER,Wood.ALDER);

           // whatErinLikes.Spec.
            List<Guitar> matchingGuitar = inventory.search(whatErinLikes);
            if (matchingGuitar.Count!=0)
            {
                foreach (var guitar in matchingGuitar)
                Console.WriteLine("Erin, you might like this " +
                  guitar.Spec.getBuilder() + " " + guitar.Spec.getModel() + " " +
                  guitar.Spec.getType() + " guitar:\n   " +
                  guitar.Spec.getBackWood() + " back and sides,\n   " +
                  guitar.Spec.getTopWood() + " top.\nYou can have it for only $" +
                  guitar.getPrice() + "!\n-------");
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }

        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.addGuitar("11277", 3999.95, Builder.Collings, "CJ", Types.ACOUSTIC,
                                Wood.Indian_Rosewood, Wood.SITKA);
            inventory.addGuitar("V95693", 1499.95, Builder.Fender, "Stratocastor", Types.ELECTRIC,
                                Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("V9512", 1549.95, Builder.Fender, "Stratocastor", Types.ELECTRIC,
                                Wood.ALDER, Wood.ALDER);
            inventory.addGuitar("122784", 5495.95, Builder.Martin, "D-18", Types.ELECTRIC,
                               Wood.MAHOGANY, Wood.ADIRONDACK);
            inventory.addGuitar("76531", 6295.95, Builder.Martin, "OM-28",Types.ACOUSTIC,
                                Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.addGuitar("70108276", 2295.95, Builder.Gibson, "Les Paul", Types.ELECTRIC,
                                Wood.MAHOGANY, Wood.MAPLE);
            inventory.addGuitar("82765501", 1890.95, Builder.Gibson, "SG '61 Reissue",
                                Types.ELECTRIC, Wood.MAHOGANY, Wood.MAHOGANY);
            inventory.addGuitar("77023", 6275.95, Builder.Martin, "D-28", Types.ACOUSTIC,
                                Wood.BRAZILIAN_ROSEWOOD, Wood.ADIRONDACK);
            inventory.addGuitar("1092", 12995.95, Builder.Olson, "SJ", Types.ACOUSTIC,
                                Wood.Indian_Rosewood, Wood.CEDAR);
            inventory.addGuitar("566-62", 8999.95, Builder.Ryan, "Cathedral", Types.ACOUSTIC,
                                Wood.COCOBOLO, Wood.CEDAR);
            inventory.addGuitar("6 29584", 2100.95,Builder.Prs, "Dave Navarro Signature",
                                Types.ELECTRIC, Wood.MAHOGANY, Wood.MAPLE);
        }
    }
}
