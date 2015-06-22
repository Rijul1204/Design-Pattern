using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern.Prototype
{
    public class Engine : IPrototype
    {
        public string Accessories { get; set; }

        public IPrototype Clone()
        {
            Engine prototype = new Engine();
            prototype.Accessories = this.Accessories;

            return prototype;
        }

        public override String ToString()
        {
            return "Engine -> " + this.Accessories;
        }
    }
}
