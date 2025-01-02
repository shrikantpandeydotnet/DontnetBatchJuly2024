using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class MathsOperation
    {

        // Method with parameters and no return value
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sum(string a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sum(int a, int b, int c)
        {
            Console.WriteLine(a + b);
        }

        // method with return type as well. 

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        // Method with parameter type as array. 

        public int SumArray(int[] arrNumbers)
        {
            int sum = 0; 

            foreach (int i in arrNumbers)
            {
                sum += i;
            }

            return sum;
        }

        // homework - return type array in method, parameter type string action = sum, subtract, multiply, divide, int a, int b, result based on action


        public int SumParamArray(string a, params int[] arrNumbers)
        {
            int sum = 0;

            foreach (int i in arrNumbers)
            {
                sum += i;
            }

            return sum;
        }



        public void PerformAction(string action, int num1, int num2)
        {
            if (action == "Sum")
            {
                Console.WriteLine(num1 + num2);
            }
            else if (action == "Subtract")
            {
                Console.WriteLine(num1 - num2);
            }
        }
    }
}
