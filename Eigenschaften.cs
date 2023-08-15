using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Autodigramm
{
     class Eigenschaften
    {
        public string farbikat;
        public string Bezeichnung;
        public int baujahr;
        public int geschwindigkeit;
        public int tankinhalt;
        public string fahrer;
        public void beschreibung()
        {
            Console.WriteLine($"{this.farbikat},{this.Bezeichnung},{this.baujahr},{this.geschwindigkeit},{this.tankinhalt},{this.fahrer}");
        }
        public void Setbaujahr(int n)
        {
            this.baujahr = n;
        }
        public int Getbaujahr()
        {
            return baujahr;
        }
        public void Setfarbikat(string n)
        {
            this.farbikat = n;
        }
        public string Getfarbikat()
        {
            return farbikat;
        }
        public void SetBezeichnung(string n)
        {
            this.Bezeichnung = n;
        }
        public string GetBezeichnung()
        {
            return Bezeichnung;
        }
        public void Setgeschwindigkeit(int n)
        {
            this.geschwindigkeit = n;
        }
        public int Getgeschwindigkeit()
        {
            return geschwindigkeit;
        }
        public void Settankinhalt(int n)
        {
            this.tankinhalt = n;
        }
        public int Gettankinhalt()
        {
            return tankinhalt;
        }
        public void Setfahrer(string n)
        {
            this.fahrer = n;
        }
        public string Getfahrer()
        {
            return fahrer;
        }
    }
}
