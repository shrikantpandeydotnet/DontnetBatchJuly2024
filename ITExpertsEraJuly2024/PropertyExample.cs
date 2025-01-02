using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class PropertyExample
    {
        // new way of defining property.. Auto IMplemented Property
        public int MyProperty { get; set; }

        public string Name { get; } = "Rajesh";

        // old way of defining property. 

        string _color;

        public string Color
        {
            // get accessor
            get
            {
                return _color;
            }

            // set accessor
            set
            {
                _color = value;
            }
        }

        // Read only property...
    }
}
