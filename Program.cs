using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Instance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clown Hans = new Clown();
            Clown Mo = new Clown();
            Katze Mic = new Katze();
            Hans.Groesse = 1.50;
            Hans.Name = "Nader";
            Mo.Groesse = 1.23;
            Mo.Name = "MO";
            Mic.Name = "Jessica";
            Mic.haarfarbe = "schwarz";
            Mic.behart = true;
            Mic.grosse = 1.69;
            //Console.WriteLine($"{Hans.Name},{Hans.Groesse}");
            //Console.WriteLine($"{Mo.Name},{Mo.Groesse}");
            Mo.TalkAbutyourself();
            Hans.TalkAbutyourself();
            Console.WriteLine($"{Mic.Name},{Mic.haarfarbe},{Mic.grosse},{Mic.behart}");

            Mo.GeldHinzufugen(20);
            Mo.GuthabenAnzeigen();
            Mo.GeldEntfernen(10);
            Mo.GuthabenAnzeigen();
            Mo.GeldEntfernen(30);
            Mo.GuthabenAnzeigen();


        }
    }
}
