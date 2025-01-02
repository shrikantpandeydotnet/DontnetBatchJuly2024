using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class AccessModifierExample
    {
        public int varPublicInt = 10;

        private int varPrivateInt = 20;

        internal string varInternalString = "Nitin";

        protected int varProtectedInt = 10;

        protected internal int varProtectedInternal = 20; 

        public void TestMethod()
        {
            varPublicInt = 200;

            varPrivateInt = 300;

            varInternalString = "Rashi";

            varProtectedInt = 100;

            varProtectedInternal = 500; 
        }
    }

    public class ChildAME : AccessModifierExample
    {
        public void testmethod()
        {
            base.varProtectedInt = 10;

            
        }
    }
}
