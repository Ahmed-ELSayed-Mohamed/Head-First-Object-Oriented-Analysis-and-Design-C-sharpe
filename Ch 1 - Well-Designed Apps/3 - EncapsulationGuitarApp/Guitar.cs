using System;
using System.Collections.Generic;
using System.Text;

namespace Guiter
{
    class Guitar
    {

        private String serialNumber;
      
        private double price;

        public Guitar(String serialNumber, double price,
                      Builder builder, String model, Types type,
                      Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.Spec = new GuitarSpec(builder, model, type, backWood, topWood);
           
        }

     public GuitarSpec Spec;
        public String getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }
        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }
         public GuitarSpec getSpec()
        {
            return Spec;
        }

    }
}
