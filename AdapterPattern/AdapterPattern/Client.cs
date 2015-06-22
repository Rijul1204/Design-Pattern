using AdapterPattern.Adapter;
using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Client
    {
        public void Run()
        {
            CustomSite site = new CustomAdapterSite();

            site.Find("test");
            site.Book("test");
        }
    }
}
