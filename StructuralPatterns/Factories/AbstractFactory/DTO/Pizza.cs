using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.AbstractFactory.DTO
{
    public abstract class Pizza
    {
        public float Grams { get; set; } 
        public PizzaSize Size { get; set; }
        public decimal Price { get; set; }
        public string Ingredients { get; set; }
        public PizzaType PizzaType { get; set; }
    }
}
