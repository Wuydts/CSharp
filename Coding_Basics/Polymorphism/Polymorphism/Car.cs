using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class Car
    {
        protected int HP { get; set; }
        protected string Color { get; set; }

        // Has a relationship
        protected CarIDInfo carID = new CarIDInfo();

        public void setCarIDInfo(int idNum, string owner)
        {
            carID.IDNum = idNum;
            carID.Owner = owner; 
        }

        public void getCarIDInfo()
        {
            Console.WriteLine("Car ID: {0} Owner: {1}", carID.IDNum, carID.Owner);
        }

        //Default Constructor
        public Car() { HP = 100; Color = "White"; }

        //Param Constructor
        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public void ShowDetails()
        {
            Console.WriteLine("You car has {0} HP, and is the color {1}.", HP, Color);
        }

        //virtual allows for overriding. 
        public virtual void Repair()
        {
            Console.WriteLine("Your car was repaired!.");
        }






    }
}
