using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class A
    {
        public virtual void MehtodA()
        {
            Console.WriteLine(" I am a A class method");
        }
    }

    public class B : A
    {
        public override void MehtodA()
        {
            Console.WriteLine("I am a new changed method");
        }
    }
}
