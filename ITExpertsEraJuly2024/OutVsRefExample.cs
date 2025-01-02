using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class OutVsRefExample
    {

        public void Sum(int i, int j, out int sum, out int subtract, out int divide , out int multiply)
        {
            sum = i + j;
            subtract = i - j;
            multiply = i * j;
             divide = i / j;

        }



        public void Subtract(ref int j, ref int k, ref int sum)
        {
            sum = j + k;
        }
    }
}
