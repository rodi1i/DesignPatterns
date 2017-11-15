using StructuralPatterns.Builder.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Builder.Factory
{
    public class BikeFactory : VehicleFactory
    {
        public BikeFactory()
            : base(new Bike())
        {
        } 

        public override void CreateBody()
        {
            this.Vehicle.Name = "bike";
            this.Vehicle.Color = "orange";
        }

        public override void CreateDoors()
        {
            this.Vehicle.Doors = null;
        }

        public override void CreateEngine()
        {
            this.Vehicle.Engine = "human power";
        }

        public override void CreateTyres()
        {
            this.Vehicle.Wheels = 2;
        }
    }
}
