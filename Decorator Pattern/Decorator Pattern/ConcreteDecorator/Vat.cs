using Decorator_Pattern.Component;
using Decorator_Pattern.Decorator.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.ConcreteDecorator
{
    public class Vat : ProductDecorator
    {
        double vatPercentage { get; set; }
        public Vat(IProduct product, double percentage)
            : base(product)
        {
            vatPercentage = percentage;
        }

        double getAddedPrice()
        {
            return ((vatPercentage * product.getPrice()) / 100.0);
        }
        public override double getPrice()
        {

            return product.getPrice() + getAddedPrice();
        }
    }
}
