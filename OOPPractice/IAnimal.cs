using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    interface IAnimal
    {
        protected void animalSound();
    }

    class Pig : IAnimal
    {
        public override void animalSound()
        {
            Console.WriteLine("wee wee");
        }
    }
}
