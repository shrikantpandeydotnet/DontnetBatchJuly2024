using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class StaticExample
    {
       public int i = 10;

        public string s = "ItExpertsEra";

        public static int varStatic = 10; 


        public static void StaticMethod()
        {
            varStatic = 200;
            Console.WriteLine("I am a static method");
        }

        public void NonStaticMethod()
        {
            s = "11000";
            varStatic = 2000; 

            Console.WriteLine("I am a non static method");

        }
    }


}
