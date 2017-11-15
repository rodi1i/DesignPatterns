using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructuralPatterns.Factories.AbstractFactory.DTO;

namespace StructuralPatterns.Factories.AbstractFactory
{
    public class PapasPizza : PizzaFactory
    {
        public override Pizza CreateKalzone()
        {
            return new KalzonePizza() 
            {
                Grams = 200,
                Ingredients = "pochti nishto",
                Price = 5,
                Size = PizzaSize.Small,
                PizzaType = PizzaType.Kalzone
            };
        }

        public override Pizza CreatePeperoni()
        {
            return new PeperoniPizza()
            {
                Grams = 1300,
                Ingredients = "mnnogo neshta ot papas pizza",
                Price = 30,
                Size = PizzaSize.Big,
                PizzaType = PizzaType.Peperoni
            };
        }

        public override Pizza CreateQuartoFormagi()
        {
            return new QuatroFormagi()
            {
                Grams = 600,
                Ingredients = "qice",
                Price = 12,
                Size = PizzaSize.Medium,
                PizzaType = PizzaType.QuartoFormagi
            };
        }
    }
}
