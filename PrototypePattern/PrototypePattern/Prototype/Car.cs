using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern.Prototype
{
    public class Car : IPrototype
    {
        public String Name { get; set; }
        public Body Body { get; set; }
        public Wheel Wheel { get; set; }
        public Engine Engine { get; set; }


        public IPrototype Clone()
        {
            Car car = new Car();

            if (Body != null) car.Body = (Body)Body.Clone();
            if (Wheel != null) car.Wheel = (Wheel)Wheel.Clone();
            if (Engine != null) car.Engine = (Engine)Engine.Clone();

            return car;
        }

        public override String ToString()
        {
            string retString = "Car : " + this.Name;

            if (Body != null) { retString += Body.ToString() + '\n'; };
            if (Wheel != null) { retString += Wheel.ToString() + '\n'; };
            if (Engine != null) { retString += Engine.ToString() + '\n'; };

            return retString + '\n';
        }
    }
}
