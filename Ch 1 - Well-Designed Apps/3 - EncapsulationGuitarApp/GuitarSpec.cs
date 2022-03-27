using System;
using System.Collections.Generic;
using System.Text;

namespace Guiter
{
    class GuitarSpec
    {

        private String model;
        private Types type;
        private Wood backWood;
        private Wood topWood;
        private Builder builder;
      

        public GuitarSpec(
                      Builder builder, String model, Types type,
                      Wood backWood, Wood topWood)
        {
           
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
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

