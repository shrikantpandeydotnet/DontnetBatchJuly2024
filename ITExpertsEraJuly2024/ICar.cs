using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public interface ICar
    {
        void Accelerator();

        void Brake();

        void Clutch();

        void Method1();
    }

    public interface ITest
    {
        void TestMethod();
        void Method1();
    }

    public class TestClass
    {
        public void TestClassMethod()
        {
            Console.WriteLine("I am a Test Class method");
        }

        void Method1()
        {
            Console.WriteLine("I am Method1");
        }
    }


    public class Honda : TestClass, ICar, ITest
    {
        public void Accelerator()
        {
            Console.WriteLine("I am Accelerator method");
        }

        public void Brake()
        {
            Console.WriteLine("I am Brake method");
        }

        public void Clutch()
        {
            Console.WriteLine("I am Clutch method");
        }

        public void TestMethod()
        {
            Console.WriteLine("I am a Test MEthod");
        }

        // Interface specific implementation.
        void ICar.Method1()
        {
            Console.WriteLine("I am ICAR Method11");
        }

        void ITest.Method1()
        {
            Console.WriteLine("I am ITest Method11");
        }

        public void HelloMethod()
        {
            Console.WriteLine("I am Hello Method1");

        }
    }
}
