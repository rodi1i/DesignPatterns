using StructuralPatterns.Builder.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Builder.Director
{
    public class VehicleConstructor
    {
        public void ConstructVehicle(VehicleFactory factory)
        {
            factory.CreateBody(); 
            factory.CreateDoors();
            factory.CreateEngine();
            factory.CreateTyres();    
        }
    }
}
