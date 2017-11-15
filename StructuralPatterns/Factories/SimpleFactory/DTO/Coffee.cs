using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.SimpleFactory.DTO
{
    public class Coffee
    {
        public int CoffeeMg { get; set; }
        public int MilkMg { get; set; }
        public CoffeeType CoffeeType { get; set; }

        public Coffee(int coffeeMg, int milkMg, CoffeeType coffeeType)
        {
            this.CoffeeMg = coffeeMg;
            this.MilkMg = milkMg;
            this.CoffeeType = coffeeType;
        }

        public override string ToString()
        { 
            return $"Coffee milligrams - {this.CoffeeMg} ; Milk milligrams - {this.MilkMg}; Type - {this.CoffeeType}";
        }
    }
}
