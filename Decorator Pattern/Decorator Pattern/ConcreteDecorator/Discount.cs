using Decorator_Pattern.Component;
using Decorator_Pattern.Decorator.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.ConcreteDecorator
{
    class Discount: ProductDecorator
    {
        double discountRate { get; set; }
        public Discount(IProduct product, double percentage)
            : base(product)
        {
            discountRate = percentage;
        }

        double getReducedPrice()
        {
            return ((discountRate * product.getPrice()) / 100.0);
        }
        public override double getPrice()
        {

            return product.getPrice() - getReducedPrice();
        }
    }
}
