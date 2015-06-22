using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern.Prototype
{
    public class Body : IPrototype
    {
       public string Color { get; set; }

       public IPrototype Clone()
       {
           Body prototype = new Body();
           prototype.Color = this.Color;

           return prototype;
        }

       public override String ToString()
       {
           return "Body -> " + this.Color;
       }
    }
}
