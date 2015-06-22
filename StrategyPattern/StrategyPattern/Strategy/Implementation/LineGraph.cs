using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Strategy.Implementation
{
    public class LineGraph : IGraphShowStrategy
    {
        public void showData(IList<Data> dataList)
        {
            Console.WriteLine("Showing in Line Graph Format : ");
            foreach( Data data in dataList){
                Console.Write(data.getData() + "   ");
            }
            Console.WriteLine("Finish");
            Console.WriteLine("");
        }
    }
}
