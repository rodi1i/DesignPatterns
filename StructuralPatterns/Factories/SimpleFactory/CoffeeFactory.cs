using StructuralPatterns.Factories.SimpleFactory.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.SimpleFactory
{
    public class CoffeeFactory
    {
        public Coffee CreateCoffee(CoffeeType coffeeType)
        {
            switch (coffeeType)
            {
                case CoffeeType.Regular:
                    return new Coffee(100, 0, coffeeType);
                case CoffeeType.Double:
                    return new Coffee(200, 0, coffeeType);
                case CoffeeType.Capuchino:
                    return new Coffee(150, 100, coffeeType);
                case CoffeeType.Mochachino:
                    return new Coffee(200, 150, coffeeType);
                case CoffeeType.Machiato:
                    return new Coffee(100, 200, coffeeType);
                default:
                    throw new ArgumentException();
            }
        }
    }
}
