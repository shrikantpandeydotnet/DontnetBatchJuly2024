using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{

    public class Parent
    {
        public void ParentMethod()
        {
            Console.WriteLine("I am a parent method");
        }
    }

    public class Child : Parent
    {
        public void ChildMethod()
        {
            Console.WriteLine("I am a child method");
        }
    }

    public class Child2 : Parent
    {
        public void ChildMethod2()
        {
            Console.WriteLine("I am a child method2");
        }
    }

    public class GrandChild : Child
    {
        public void GrandChildMethod()
        {
            Console.WriteLine(" I am a grand child method");
        }
    }

    public class GrandChild2 : Child2
    {
        public void GrandChildMethod2()
        {
            Console.WriteLine(" I am a grand child method2");
        }
    }

}
