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
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            /*Pig obj = new Pig();
            obj.animalSound();
            Level enumString = Level.Second;
            Console.WriteLine($"{enumString}");*/

            /*int[] numArr = { 1, 2, 3 };
            try
            {
                int num = numArr[10];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Try again!");
            }*/

            checkAge(15);
        }
    }
}
