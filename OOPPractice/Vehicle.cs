using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Vehicle
    {
        protected string brand; // attribute/field/variable

        public string Brand // property
        {
            get { return brand; }
            set { brand = value; }
        }
        public virtual void Model()
        {
            Console.WriteLine("It's default model");
        }
    }

    class Car : Vehicle
    {
        public override void Model()
        {
            Console.WriteLine("It's Car");
        }
    }

    class Truck : Vehicle
    {
        public override void Model()
        {
            Console.WriteLine("It's Truck");
        }
    }
}
