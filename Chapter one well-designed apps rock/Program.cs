using System;
using System.Reflection;

namespace Chapter_one_well_designed_apps_rock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up Rick’s guitar inventory
            Inventory inventory = new Inventory();
            initializeInventory(inventory);
            Guitar whatErinLikes = new Guitar("", 0, "fender", "Stratocastor",
            "electric", "Alder", "Alder");
            Guitar guitar = inventory.search(whatErinLikes);
            if (guitar != null)
            {
                  Console.WriteLine("Erin, you might like this " +
                guitar.getBuilder() + " " +guitar.getModel() + " "
+guitar.getType() + " guitar:\n " +
                guitar.getBackWood() + " back and sides,\n " +
                guitar.getTopWood() + " top.\nYou can have it for only $" +
                guitar.getPrice() + "!") ;
            }
            else
            {
                  Console.WriteLine("Sorry, Erin, we have nothing for you.") ;
            }
        }
        private static void initializeInventory(Inventory inventory)
        {
            // Add guitars to the inventory...
            inventory.addGuitar("1234",22.5,"ahmed","c","type-c","wood1","wood2");
            inventory.addGuitar("V95693”,", 22.5, "Fender", "Stratocastor", "electric", "Alder", "Alder");

        }
    }
    }

