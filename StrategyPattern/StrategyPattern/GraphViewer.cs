using StrategyPattern.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class GraphViewer
    {
        IGraphShowStrategy GraphShowStrategy;
        IList<Data> dataList = new List<Data>();

        public void setGraphShowStrategy(IGraphShowStrategy graphShowStrategy)
        {
            GraphShowStrategy = graphShowStrategy;
        }
        
        public void add(Data data){
            dataList.Add(data);
        }

        public void showData()
        {
            GraphShowStrategy.showData(dataList);
        }
    }
}
