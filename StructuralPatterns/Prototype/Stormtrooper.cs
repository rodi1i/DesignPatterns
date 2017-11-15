using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Prototype
{
    public class Stormtrooper : StormtrooperPrototype
    {
        public float Height { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public TrooperCar TrooperCar { get; set; }

        public Stormtrooper()
        {
        }

        private Stormtrooper(Stormtrooper trooper)
        {
            this.Age = trooper.Age;
            this.Height = trooper.Height;
            this.Name = trooper.Name;
            this.TrooperCar = trooper.TrooperCar;
        }


        public override Stormtrooper Clone()
        {
            var trooper = this.MemberwiseClone() as Stormtrooper;
            //var trooper = new Stormtrooper(this);

            return trooper;
        }
    }
}
