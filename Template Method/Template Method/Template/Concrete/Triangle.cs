using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template_Method.Template.Abstract;

namespace Template_Method.Template.Concrete
{
    public class Triangle : Shape
    {
        public override void DoRender()
        {
            Console.WriteLine("Rendering Triangle");
            foreach (Point p in points)
            {
                Console.Write(p.X + " " + p.Y + "   ");
            }
            Console.WriteLine("");
        }

        public override Boolean DoCheckValidity()
        {
            if (points.Count != 3)
            {
                return false;
            }
            return true;
        }

        public override void beforeDraw()
        {
            Console.WriteLine("\nStart Drawing Triangle . . .\n ");
        }
        public override void afterDraw()
        {
            Console.WriteLine("\nFinish Drawing Triangle\n");
        }
    }
}
