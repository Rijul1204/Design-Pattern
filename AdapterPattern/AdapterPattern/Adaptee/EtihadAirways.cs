using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adaptee
{
    public class EtihadAirways
    {
        public bool CheckAvailability(string s)
        {
            return true;
        }

        public void Book(string s)
        {
            Console.Out.WriteLine("Booking " + s + " from Etihad");
        }       

        public void Search(string s)
        {
            Console.Out.WriteLine("Searching . .  " + s + " from Etihad");
        }
    }
}
