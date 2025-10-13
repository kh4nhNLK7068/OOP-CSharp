using System;

namespace OOPPractice
{

    public enum Level
    {
        First = 1,
        Second = 2,
        Third = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig obj = new Pig();
            obj.animalSound();
            Level enumString = Level.Second;
            Console.WriteLine($"{enumString}");
        }
    }
}
