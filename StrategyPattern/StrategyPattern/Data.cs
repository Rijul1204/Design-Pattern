using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Data
    {
        int x, y;

        public Data(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public string getData()
        {
            return x.ToString() + ", " + y.ToString();
        }
    }
}
