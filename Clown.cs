using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Instance
{
    class Clown
    {
        public string Name;
        public double Groesse;
        public int Guthaben = 0;

        public void TalkAbutyourself()
        {
            Console.WriteLine($"\"My Name is {this.Name} and i am {this.Groesse} Meter Gross\"");
        }
        public void GeldHinzufugen(int zahl)
        {
            this.Guthaben += zahl;
        }
        public void GeldEntfernen(int zahl)
        {
            if (this.Guthaben > 0 && zahl < this.Guthaben)
                this.Guthaben -= zahl;
            else
                Console.WriteLine("so vile Geld hast du Nicht");
        }
        public void GuthabenAnzeigen()
        {
            Console.WriteLine(this.Guthaben);
        }
    }
}
