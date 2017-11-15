using StructuralPatterns.Factories.FactoryMethod;
using StructuralPatterns.Factories.FactoryMethod.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.FactoryMethod
{
    public abstract class GsmFactory
    {
        public abstract Gsm CreateGsm();
    }
}
 