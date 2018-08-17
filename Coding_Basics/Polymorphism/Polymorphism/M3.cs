using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    class M3:BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model) { Model = model; }


        // If uncommented we can see that it cannot override Repair due to the sealed statement. 
        //public override void Repair()
        //{
        //    base.Repair();
        //}
    }
}
