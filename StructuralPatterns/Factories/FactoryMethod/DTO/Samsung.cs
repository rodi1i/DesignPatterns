using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Factories.FactoryMethod.DTO
{
    public class Samsung : Gsm
    {
        public override void Start()
        {
            Console.WriteLine("Samsung started");
        }

        public void TalkAsSamsung() 
        {
            Console.WriteLine("Hello I am Samsung");
        }
    }
}
