using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Builder.DTO
{
    public abstract class Vehicle
    {
        public int? Doors { get; set; }
        public int Wheels { get; set; }
        public string Name { get; set; }
        public string Color { get; set; } 
        public string Engine { get; set; }
    }
}
