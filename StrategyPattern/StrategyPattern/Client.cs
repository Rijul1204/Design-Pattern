using StrategyPattern.Strategy.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Client
    {
        public void run()
        {
            GraphViewer graphViewer = new GraphViewer();
            
            graphViewer.add(new Data(1,2));
            graphViewer.add(new Data(1,3));
            graphViewer.add(new Data(1,4));
            graphViewer.add(new Data(1,5));

            graphViewer.setGraphShowStrategy(new LineGraph());
            graphViewer.showData();

            graphViewer.setGraphShowStrategy(new BarChart());
            graphViewer.showData();
            
        }       
    }
}
