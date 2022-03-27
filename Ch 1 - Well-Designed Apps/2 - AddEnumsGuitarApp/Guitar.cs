using System;
using System.Collections.Generic;
using System.Text;

namespace Guiter
{
    class Guitar
    {

        private String serialNumber,model;
        private Types type;
        private Wood backWood;
        private Wood topWood;
        private Builder builder;
        private double price;

        public Guitar(String serialNumber, double price,
                      Builder builder, String model, Types type,
                      Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

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
        public Builder getBuilder()
        {
            return builder;
        }
        public String getModel()
        {
            return model;
        }
        public Types getType()
        {
            return type;
        }
        public Wood getBackWood()
        {
            return backWood;
        }
        public Wood getTopWood()
        {
            return topWood;
        }

    }
}
