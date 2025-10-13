using System;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle myCar = new Car();
            Vehicle myTruck = new Truck();

            myCar.Brand = "Toyota";
            myTruck.Brand = "Huyndai";

            myCar.Model();
            myTruck.Model();

            Pig myObj = new Pig();
            myObj.animalSound();
        }
    }
}
