using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Component
{
    public interface IProduct
    {
        double getPrice();
        int getWeight();
        string getName();
    }
}
