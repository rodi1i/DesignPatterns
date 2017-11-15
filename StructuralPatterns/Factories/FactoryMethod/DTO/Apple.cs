using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.FactoryMethod.DTO
{
    public class Apple: Gsm
    {
        public override void Start()
        {
            Console.WriteLine("Apple started");
        }

        public void TalkAsApple() 
        {
            Console.WriteLine("Hello I am Apple");
        }
    }
}
