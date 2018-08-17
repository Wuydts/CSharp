using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Audi:Car
    {
        private string brand = "Audi";
        private string Model { get; set; }

        //Default Constructor utilizing base class from Car. 
        public Audi(int hp, string color, string model) : base(hp, color) { Model = model; }

        public void ShowDetails()
        {
            Console.WriteLine("Brand: " + brand + " HP: " + HP + " color: " + Color);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi " + Model + " was repaired.");
        }

    }
}
