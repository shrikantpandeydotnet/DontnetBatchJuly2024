using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public abstract class AbstractExample
    {
        public AbstractExample() //1
        {
            Console.WriteLine("I am abstract class constructor");   
        }

        static AbstractExample() //2
        {

        }

        public void Method1()
        {
            Console.WriteLine("I am Method 1 ");
        }

        public abstract void Method2();
        public abstract void Method3();
    }

    public class ChildAbstract : AbstractExample
    {
        public ChildAbstract() //3
        {
            Console.WriteLine("I am child class constructor");
        }

        static ChildAbstract() //4
        {

        }

        public override void Method2()
        {
            Console.WriteLine("I am Method2");
        }

        public override void Method3()
        {
            Console.WriteLine("I am Method3");
        }

        public void TestMethod()
        {
         Console.WriteLine("I am created by another person");
        }
    }
}
