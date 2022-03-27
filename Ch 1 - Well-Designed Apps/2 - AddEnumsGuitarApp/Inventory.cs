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
                              Builder builder, String model,
                              Types type, Wood backWood, Wood topWood)
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

                Builder builder = searchGuitar.getBuilder();
                if (
                    (builder !=(guitar.getBuilder())))
                    continue;
                String model = searchGuitar.getModel().ToLower();
                if ((model != null) && (model!="") &&
                    (model != ((guitar.getModel()).ToLower())))
                    continue;
                Types type = searchGuitar.getType();
                if (type !=guitar.getType())
                    continue;
                Wood backWood = searchGuitar.getBackWood();
                if (backWood != guitar.getBackWood())
                    continue;
                Wood topWood = searchGuitar.getTopWood();
                if (topWood!=guitar.getTopWood())
                    continue;
                return guitar;
            }
            return null;
        }


    }
}
