using StructuralPatterns.Builder.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Builder.Factory
{
    public class CarFactory : VehicleFactory
    {
        public CarFactory()
            : base(new Car())
        {
        }

        public override void CreateBody()
        {
            this.Vehicle.Name = "caaar";
            this.Vehicle.Color = "red";
        }

        public override void CreateDoors()
        {
            this.Vehicle.Doors = 5;
        }

        public override void CreateEngine()
        {
            this.Vehicle.Engine = "car engine";
        }

        public override void CreateTyres()
        {
            this.Vehicle.Wheels = 4;
        }
    }
}
