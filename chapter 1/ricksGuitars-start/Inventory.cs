using System;
using System.Collections.Generic;
using System.Text;

namespace Guiter
{
    class Inventory
    {
        private List<Guitar> guitars;

        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price,
                              String builder, String model,
                              String type, String backWood, String topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,
                                       model, type, backWood, topWood);
            guitars.Add(guitar);
        }
        public Guitar getGuitar(String serialNumber)
        {
            foreach (var i  in guitars)
            {
                Guitar guitar = i;
                if (guitar.getSerialNumber()==serialNumber)
                {
                    return guitar;
                }
            }
            return null;
        }
        public Guitar search(Guitar searchGuitar)
        {
            foreach (var i in guitars)
            {
                Guitar guitar = i;
               
                String builder = searchGuitar.getBuilder();
                if ((builder != null) && ( builder !=" ") &&
                    (builder !=(guitar.getBuilder())))
                    continue;
                String model = searchGuitar.getModel();
                if ((model != null) && (model!="") &&
                    (model != guitar.getModel()))
                    continue;
                String type = searchGuitar.getType();
                if ((type != null) && (searchGuitar !=null) &&
                    (type !=guitar.getType()))
                    continue;
                String backWood = searchGuitar.getBackWood();
                if ((backWood != null) && (backWood !="") &&
                    (backWood != guitar.getBackWood()))
                    continue;
                String topWood = searchGuitar.getTopWood();
                if ((topWood != null) && (topWood != "") &&
                    (topWood!=guitar.getTopWood()))
                    continue;
                return guitar;
            }
            return null;
        }


    }
}
