using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "Blue", "A4"),
                new BMW(250, "Red", "M4")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmw2 = new BMW(200, "Black", "Z3");
            Car audi2 = new Audi(100, "Black", "A3");
            bmw2.ShowDetails();
            audi2.ShowDetails();

            BMW bmw3 = new BMW(300, "Green", "M5");
            bmw3.ShowDetails();

            Car carB = (Car)bmw3;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "Red", "M3extraGreat");
            myM3.Repair();

            bmw2.setCarIDInfo(1, "Christopher Wuydts");
            audi2.setCarIDInfo(2, "Christopher Wuydts");
            bmw2.getCarIDInfo();
            audi2.getCarIDInfo();

           

        }
    }
}
