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
     /*   public Guitar getGuitar(String serialNumber)
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
        }*/
        public List<Guitar> search(GuitarSpec searchGuitar)
        {
            List <Guitar> matchingGuitar = new List<Guitar>();
            foreach (var i in guitars)
            {
                Guitar guitar = i;

               Builder builder = searchGuitar.getBuilder();
                if (
                    (builder !=(guitar.Spec.getBuilder())))
                    continue;
                String model = searchGuitar.getModel().ToLower();
                if ((model != null) && (model!="") &&
                    (model != ((guitar.Spec.getModel()).ToLower())))
                    continue;
                Types type = searchGuitar.getType();
                if (type !=guitar.Spec.getType())
                    continue;
                Wood backWood = searchGuitar.getBackWood();
                if (backWood != guitar.Spec.getBackWood())
                    continue;
                Wood topWood = searchGuitar.getTopWood();
                if (topWood!=guitar.Spec.getTopWood())
                    continue;

                matchingGuitar.Add(guitar);
            }
            return matchingGuitar;
        }


    }
}
