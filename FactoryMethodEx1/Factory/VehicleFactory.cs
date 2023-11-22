using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx1.Factory
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();

        public IVehicle OrderVehicle()
        {
            IVehicle vehicle = CreateVehicle();
            //demostracion
            vehicle.Start();
            vehicle.Drive();
            vehicle.Stop();

            return vehicle;
        }
    }
}
