using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_one_well_designed_apps_rock
{
    public class Inventory
    {   
        public List<Guitar> guitars;
        public Inventory()
        {
            this.guitars = new List<Guitar> ();
        }

        public void addGuitar(string serialNumber, double price, string builder, string model, string type, string backWood, string topWood)
        {
            guitars.Add(new Guitar(serialNumber, price, builder, model, type, backWood, topWood));
        }
        public Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in guitars)
            {
                if (guitar.getSerialNumber() == serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }

        public List <Guitar> search(Guitar searchGuitar)
        {
            List <Guitar> guitars = new List <Guitar>();
            foreach (var guitar in guitars)
            {
                if ( searchGuitar.getModel().ToLower() !=guitar.getModel().ToLower() )
                {
                    continue;
                }
                if (searchGuitar.getBuilder() != guitar.getBuilder())
                {
                    continue;
                }
                if (searchGuitar.getType() != guitar.getType())
                {
                    continue;
                }
                if (searchGuitar.getTopWood() != guitar.getTopWood())
                {
                    continue;
                }
                if (searchGuitar.getBackWood() != guitar.getBackWood())
                {
                    continue;
                }
                guitars.Add(guitar);
            }
            return guitars;
        }
    }
}
