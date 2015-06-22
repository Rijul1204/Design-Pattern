using AdapterPattern.Adaptee;
using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class CustomAdapterSite : CustomSite
    {
        public EtihadAirways adaptee { get; set; }

        public CustomAdapterSite()
        {
            adaptee = new EtihadAirways();
        }

        public override void Find(string s)
        {
            adaptee.Search(s);
        }

        public override bool Book(string s)
        {
            if (adaptee.CheckAvailability(s) == false) return false;
            adaptee.Book(s);
            return true;
        }
    }
}
