using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodEx1
{
    //Esta interfaz define que es lo que define un vehiculo
    //en este sistema debe; arrancar, detenerse, y ser conducido
    public interface IVehicle
    {
        public void Start();
        public void Stop();
        public void Drive();
    }
}
