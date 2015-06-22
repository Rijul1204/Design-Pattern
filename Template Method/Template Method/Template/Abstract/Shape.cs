using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_Method.Template.Abstract
{
    public abstract class Shape
    {
        protected IList<Point> points = new List<Point>();

        public void Draw()
        {
            if (DoCheckValidity())
            {
                beforeDraw();
                DoRender();
                afterDraw();
            }
            else
            {
                printErrorMessage();
            }
        }

        public abstract void DoRender();

        public abstract Boolean DoCheckValidity();


        public virtual void printErrorMessage() { }
        public virtual void beforeDraw() { }
        public virtual void afterDraw() { }

        public void add(Point p)
        {
            points.Add(p);
        }
    }
}
