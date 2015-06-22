using Decorator_Pattern.Component;
using Decorator_Pattern.Decorator.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.ConcreteDecorator
{
    public class FreeOffer : ProductDecorator
    {
        public FreeOffer(IProduct product)
            : base(product)
        {
        }
        public override double getPrice()
        {

            return product.getPrice() - product.getPrice();
        }
    }
}
