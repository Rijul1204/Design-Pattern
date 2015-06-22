using Decorator_Pattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.ConcreteComponent
{
    public class Book : IProduct
    {
        public double getPrice()
        {
            return 100;
        }

        public int getWeight()
        {
            return 3;
        }
        public string getName()
        {
            return "Book";
        }
    }
}
