using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern.Prototype
{
    public class Wheel : IPrototype
    {
        public string Accessories { get; set; }

        public IPrototype Clone()
        {
            Wheel prototype = new Wheel();
            prototype.Accessories = this.Accessories;

            return prototype;
        }

        public override String ToString()
        {
            return "Wheel -> " + this.Accessories;
        }
    }
}
