using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    abstract class Animal
    {
        protected string _name;
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz!");
        }
    }

    /*class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("wee wee");
        }
    }*/
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("wee wee!");
        }
    }
}
