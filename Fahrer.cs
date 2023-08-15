using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodigramm
{
    class Fahrer
    {
        public int erhohen;
        public int geschwindischkeiterhohen(int zahl)
        {
           
           return this.erhohen += zahl;
            
            //Console.WriteLine($"{this.erhohen}kmh");
        }
    }
}
