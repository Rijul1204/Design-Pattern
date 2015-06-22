using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy.Implementation
{
    public class BarChart : IGraphShowStrategy
    {
        public void showData(IList<Data> dataList)
        {
            Console.WriteLine("Showing in Bar Chart Format : ");
            foreach( Data data in dataList){
                Console.Write(data.getData() + "  ");
            }
            Console.WriteLine("Finish");
            Console.WriteLine("");
        }
    }
}
