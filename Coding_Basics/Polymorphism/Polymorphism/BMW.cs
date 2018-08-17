using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    //a BMW is a car
    class BMW:Car
    {
        protected string brand = "BMW";
        protected string Model { get; set; }

        //Default Constructor utilizing base class from Car. 
        public BMW(int hp, string color, string model):base(hp, color) { Model = model; }

        public new void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + " HP: " + HP + " color: " + Color);
        }

        // sealed means it can't be overwritten again
        public sealed override void Repair()
        {
            Console.WriteLine("The BMW " + Model + " was repaired.");
        }

    }
}
