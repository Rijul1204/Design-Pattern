using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Method.Template.Abstract;

namespace Template_Method.Template.Concrete
{
    public class Square : Shape
    {
        public override void DoRender()
        {
            Console.WriteLine("Rendering Square");
            foreach (Point p in points)
            {
                Console.Write(p.X + " " + p.Y + "   ");
            }
            Console.WriteLine("");
        }

        public override Boolean DoCheckValidity()
        {
            if (points.Count != 4 && points.Count!=2)
            {
                return false;
            }
            return true;
        }

        public override void beforeDraw()
        {
            Console.WriteLine("\nStart Drawing Square . . .\n ");
        }
        public override void afterDraw()
        {
            Console.WriteLine("\nFinish Drawing Square\n");
        }

        public override void printErrorMessage(){
            Console.WriteLine("\nSorry Coudn't draw Square\n");
        }
    }
}
