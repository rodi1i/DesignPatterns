using StructuralPatterns.Factories.AbstractFactory.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.AbstractFactory
{
    public abstract class PizzaFactory
    {
        public abstract Pizza CreatePeperoni();
        public abstract Pizza CreateQuartoFormagi();
        public abstract Pizza CreateKalzone();
    }
}
