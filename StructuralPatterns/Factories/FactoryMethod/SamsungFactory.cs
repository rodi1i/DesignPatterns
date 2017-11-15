using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Factories.FactoryMethod;
using StructuralPatterns.Factories.FactoryMethod.DTO;

namespace StructuralPatterns.Factories.FactoryMethod
{
    public class SamsungFactory : GsmFactory
    {
        public override Gsm CreateGsm()
        {
            return new Samsung() { Colors = 123, DimensionX = 3, DimensionY = 321, DimensionZ = 32, Model = "galaxy s98" };
        }
    }
}
 