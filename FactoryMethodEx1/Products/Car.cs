using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx1.Products
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive the car");
        }

        public void Start()
        {
            Console.WriteLine("Starting the car");
        }

        public void Stop()
        {
            Console.WriteLine("Stoping the car");
        }
    }
}
