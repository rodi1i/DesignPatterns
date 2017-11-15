using StructuralPatterns.Builder.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Builder.Factory
{
    public abstract class VehicleFactory
    {
        internal Vehicle Vehicle;
        internal VehicleFactory(Vehicle vehicle)
        {
            this.Vehicle = vehicle;
        }

        public abstract void CreateEngine();
        public abstract void CreateDoors();
        public abstract void CreateTyres();
        public abstract void CreateBody();
    }
}
