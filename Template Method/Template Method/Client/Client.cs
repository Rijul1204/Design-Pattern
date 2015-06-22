using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Method.Template.Abstract;
using Template_Method.Template.Concrete;

namespace Template_Method
{
    public class Client
    {
        public void run()
        {
            Shape shape = new Triangle();
            
            shape.add(new Point(0, 0));
            shape.add(new Point(1, 1));
            shape.add(new Point(3, 3));

            shape.Draw();


            shape = new Square();

            shape.add(new Point(0, 0));
            shape.add(new Point(1, 1));
            shape.add(new Point(3, 3));
            shape.add(new Point(4, 4));

            shape.Draw();

        }
        
    }
}
