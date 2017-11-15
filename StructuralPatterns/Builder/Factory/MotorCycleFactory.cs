using StructuralPatterns.Builder.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Builder.Factory
{
    public class MotorCycleFactory:VehicleFactory
    {
        public MotorCycleFactory()
            : base(new Motorcycle())
        {
        }

        public override void CreateBody()
        {
            this.Vehicle.Name = "motor cycle";
            this.Vehicle.Color = "black";
        }

        public override void CreateDoors()
        {
            this.Vehicle.Doors = null;
        }

        public override void CreateEngine()
        {
            this.Vehicle.Engine = "harley engine";
        }

        public override void CreateTyres()
        {
            this.Vehicle.Wheels = 16;
        }

    }
}
