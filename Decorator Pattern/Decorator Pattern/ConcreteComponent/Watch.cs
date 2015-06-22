using Decorator_Pattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.ConcreteComponent
{
    public class Watch : IProduct
    {
        public double getPrice()
        {
            return 1000;
        }

        public int getWeight()
        {
            return 2;
        }

        public string getName() { return "Watch"; }
    }
}
