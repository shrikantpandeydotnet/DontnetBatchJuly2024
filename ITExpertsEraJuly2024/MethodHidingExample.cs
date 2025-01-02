using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class MethodHidingExample
    {
        public void Method1()
        {
            Console.WriteLine("I am parent class method");
        }
    }

    public class ChildMethodHiding : MethodHidingExample
    {
        public new void Method1()
        {
            Console.WriteLine("i am child class method");
        }
    }
}
