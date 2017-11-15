using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.FactoryMethod.DTO
{
    public class Gsm
    {
        public string Model { get; set; }
        public float DimensionX { get; set; }
        public float DimensionY { get; set; }
        public float DimensionZ { get; set; }
        public int Colors { get; set; }

        public virtual void Start() { }
        public override string ToString() 
        {
            return $"Model {this.Model}; Dimension X {this.DimensionX}; Dimension Y {this.DimensionY}; Dimension Z {this.DimensionZ}; Colors {this.Colors}";
        }
    }
}
