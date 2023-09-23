using System;
using System.Collections.Generic;
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
            Guitar whatErinLikes = new Guitar("", 0, Bulider.FENDER.ToString(), "Stratocastor",
            Type.electric.ToString(), "Alder", "Alder");
           List <Guitar> guitars = inventory.search(whatErinLikes);
            if (guitars.Count > 0)
            {
                foreach (var guitar in guitars) {
                    Console.WriteLine("Erin, you might like this " +
                  guitar.getBuilder() + " " + guitar.getModel() + " "
                  + guitar.getType() + " guitar:\n " +
                  guitar.getBackWood() + " back and sides,\n " +
                  guitar.getTopWood() + " top.\nYou can have it for only $" +
                  guitar.getPrice() + "!");
                }
            }
            else
            {
                  Console.WriteLine("Sorry, Erin, we have nothing for you.") ;
            }
        }
        private static void initializeInventory(Inventory inventory)
        {
            // Add guitars to the inventory...
            inventory.addGuitar("V95693", 22.5,Bulider.FENDER.ToString(),"Stratocastor", Type.electric.ToString(),Wood.IndianRosewood.ToString(),Wood.BrazilianRosewood.ToString());
            inventory.addGuitar("V95666”,", 30.55, Bulider.COLLINGS.ToString(), "Stratocastor", Type.acoustic.ToString(),Wood.IndianRosewood.ToString(), Wood.IndianRosewood.ToString());

        }
    }
    }

