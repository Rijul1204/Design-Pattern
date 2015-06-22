using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Target
{
    public class CustomSite
    {
        public virtual void Find(string s)
        {
            Console.Out.WriteLine("Searching . . . . " +s);
        }

        public virtual bool Book(string s)
        {
            Console.Out.WriteLine("Booking . . . . " + s);
            return true;
        }
    }
}
