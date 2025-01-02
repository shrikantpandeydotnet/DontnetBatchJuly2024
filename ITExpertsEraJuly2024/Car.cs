using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITExpertsEraJuly2024
{
    public class Car
    {
        //properties

        public string BrandName { get; set; }
        public string CarName { get; set; }
        public int NoOfSeats { get; set; }

        // functionality , methods

        public void PrintBrandName()
        {
            Console.WriteLine("Brand name is " + BrandName);
        }

        public int Accelerator(int pressure)
        {
            int speed = pressure * 10;

            return speed;

        }

        public int Brake(int pressure)
        {
            int speed = pressure  /10 ;

            return speed;

        }

        public int Clutch(int pressure)
        {
            int speed = pressure;

            return speed;
        }
    }

}
