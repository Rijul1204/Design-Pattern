using Decorator_Pattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator.Implementation
{
    public abstract class ProductDecorator : IProductDecorator
    {
        protected IProduct product { get; set; }

        public ProductDecorator(IProduct Product)
        {
            this.product = Product;
        }

        public virtual double getPrice()
        {
            return product.getPrice();
        }

        public int getWeight()
        {
            return product.getWeight();
        }
        public string getName()
        {
            return product.getName();
        }
    }
}
