using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Factories.AbstractFactory.DTO;

namespace StructuralPatterns.Factories.AbstractFactory
{
    public class Dominoes : PizzaFactory
    {
        public override Pizza CreateKalzone()
        {
            return new KalzonePizza()
            {
                Grams = 800,
                Ingredients = "kot sa setish",
                Price = 15,
                Size = PizzaSize.Big,
                PizzaType = PizzaType.Kalzone
            };
        }

        public override Pizza CreatePeperoni()
        {
            return new PeperoniPizza()
            {
                Grams = 600,
                Ingredients = "gybi",
                Price = 12,
                Size = PizzaSize.Medium,
                PizzaType = PizzaType.Peperoni
            };
        }

        public override Pizza CreateQuartoFormagi()
        {
            return new QuatroFormagi()
            {
                Grams = 900,
                Ingredients = "zelenchuci",
                Price = 28,
                Size = PizzaSize.Big,
                PizzaType = PizzaType.QuartoFormagi
            };
        }
    }
}
