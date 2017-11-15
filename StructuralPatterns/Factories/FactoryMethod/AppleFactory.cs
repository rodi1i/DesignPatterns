using StructuralPatterns.Factories.FactoryMethod.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.FactoryMethod
{
    public class AppleFactory : GsmFactory
    {
        public override Gsm CreateGsm()
        {
            return new Apple() { Colors = 13, DimensionX = 13, DimensionY = 1, DimensionZ = 3, Model = "IPhone 123" };
        }
    }
}
