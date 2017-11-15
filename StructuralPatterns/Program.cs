using StructuralPatterns.Builder.Director;
using StructuralPatterns.Builder.Factory;
using StructuralPatterns.Factories;
using StructuralPatterns.Factories.AbstractFactory;
using StructuralPatterns.Factories.AbstractFactory.DTO;
using StructuralPatterns.Factories.FactoryMethod;
using StructuralPatterns.Factories.FactoryMethod.DTO;
using StructuralPatterns.Factories.SimpleFactory;
using StructuralPatterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns
{
    class Program
    { 
        static void Main(string[] args)
        {
            //==============================================================================================
            //                                      Singleton
            //==============================================================================================
            //Parallel.For(0, 5, x => NestedThreadSafeLogger.Instance().Log(x.ToString()));
            //NestedThreadSafeLogger.Instance().PrintLog();
            //==============================================================================================


            //==============================================================================================
            //                                      Simple factory
            //==============================================================================================
            //CoffeeFactory cf = new CoffeeFactory();
            //var coffee1 = cf.CreateCoffee(CoffeeType.Capuchino);
            //var coffee2 = cf.CreateCoffee(CoffeeType.Mochachino);
            //var coffee3 = cf.CreateCoffee(CoffeeType.Double);
            //Console.WriteLine(coffee1.ToString());
            //Console.WriteLine(coffee2.ToString());
            //Console.WriteLine(coffee3.ToString());
            //==============================================================================================


            //==============================================================================================
            //                                      Factory method
            //==============================================================================================
            //var mobilePhoneFactory = new SamsungFactory();
            //var gsm = CreateGsm(mobilePhoneFactory);
            //==============================================================================================


            //==============================================================================================
            //                                      Abstract Factory
            //==============================================================================================
            //var dominoes = new Dominoes();
            //var papas = new PapasPizza();
            //var pizza1 = CreatePizza(dominoes, PizzaType.Kalzone);
            //var pizza2 = CreatePizza(dominoes, PizzaType.QuartoFormagi);
            //var pizza3 = CreatePizza(dominoes, PizzaType.Peperoni);

            //var pizza4 = CreatePizza(papas, PizzaType.Kalzone);
            //var pizza5 = CreatePizza(papas, PizzaType.QuartoFormagi);
            //var pizza6 = CreatePizza(papas, PizzaType.Peperoni);
            //==============================================================================================

            //==============================================================================================
            //                                      Builder
            //==============================================================================================
            //var constructor = new VehicleConstructor();
            //var factory = new CarFactory();
            //constructor.ConstructVehicle(factory);
            //==============================================================================================

            //==============================================================================================
            //                                      Prototype
            //==============================================================================================
            var trooper = new Stormtrooper();
            trooper.Age = 12;
            trooper.Height = 12432;
            trooper.Name = "naseme";
            trooper.TrooperCar = new TrooperCar() { HorsePower = 123 };
            var clonedTrooper = trooper.Clone();
            trooper.TrooperCar = null;

           var areEqual = Object.ReferenceEquals(clonedTrooper.TrooperCar, trooper.TrooperCar);
            //==============================================================================================
        }

        private static Gsm CreateGsm(GsmFactory factory)
        {
            var gsm = factory.CreateGsm();
            return gsm;
        }

        private static Pizza CreatePizza(PizzaFactory factory, PizzaType pizzaType)
        {
            switch (pizzaType)
            {
                case PizzaType.Kalzone:
                    return factory.CreateKalzone();
                case PizzaType.Peperoni:
                    return factory.CreatePeperoni();
                case PizzaType.QuartoFormagi:
                    return factory.CreateQuartoFormagi();
                default:
                    throw new NotImplementedException();
                    break;
            }
        }
    }
}
