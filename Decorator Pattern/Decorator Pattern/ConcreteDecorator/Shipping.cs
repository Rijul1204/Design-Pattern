using Decorator_Pattern.Component;
using Decorator_Pattern.Decorator.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.ConcreteDecorator
{
    public class Shipping: ProductDecorator
    {
        int ShippingCharge { get; set; }

        public Shipping(IProduct product,int charge)
            : base(product)
        {
            ShippingCharge = charge;
        }

        double getAddedPrice()
        {
            return (product.getWeight() * ShippingCharge);
        }

        public override double getPrice()
        {
            return product.getPrice() + getAddedPrice();
        } 
    }
}
