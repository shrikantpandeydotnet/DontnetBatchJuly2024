using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class ExceptionHandleExample
    {

        public void TestMethod(int a)
        {
            try
            {
                if (a < 0)
                {
                    throw new ArgumentException("Argument passed in the method is not correct");
                }

                try
                {

                    int a1 = 2000;
                    int b = 0;

                    int c = a1 / b;

                    Console.WriteLine(c);
                }
                catch (Exception ex)
                {

                   throw ex;
                }

                int i = 1000;

                int j = 10;

                int result = i / j;

                Console.WriteLine("Result passsed successfully " + result);
            }
            catch (ArgumentException argex)
            {
                Console.WriteLine("There is an exception related to the argument");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("There is divide by zero exception");

            }
            catch (Exception ex)
            {

                Console.WriteLine("There is some exception in the system. Pleae contact IT");
            }
            finally
            {
                Console.WriteLine("This is finally block and it will execute irrespective of exception");
            }

        }
    }
}
