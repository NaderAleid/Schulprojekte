using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodigramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eigenschaften car = new Eigenschaften();
            Fahrer fahrer = new Fahrer();
            //car.farbikat = "KIa";
            //car.Bezeichnung = "XE";
            //car.geschwindigkeit = 200;
            //car.baujahr = 2020;
            //car.tankinhalt = 30;
            //car.fahrer = "Ich fahre selber das Auto"
            car.Setfarbikat("Auto model: BMW");
            Console.WriteLine(car.Getfarbikat());
            car.SetBezeichnung("Bezeichnung: XE3");
            Console.WriteLine(car.GetBezeichnung());
            car.Setbaujahr(2020);
            Console.WriteLine($"baujahr: { car.Getbaujahr()}");
            car.Setgeschwindigkeit(200);
            Console.WriteLine($"geschwindigkeit: {car.Getgeschwindigkeit()}");
            car.Setbaujahr(2020);
            Console.WriteLine($"baujahr: {car.Getbaujahr()}");
            car.Settankinhalt(30);
            Console.WriteLine($"tankinhalt: {car.Gettankinhalt()}");
            car.Setfahrer("Fahrer Name: Nader");
            Console.WriteLine(car.Getfahrer());
            Console.Write("geschwindischkeiterhohe:");
            Console.ReadLine();
            Console.Write("Um wie viel km/h willst du deine Geschwidigkeit erhöhen? ");
            int input = int.Parse(Console.ReadLine());
            //fahrer.geschwindischkeiterhohen(input);
            Console.WriteLine(fahrer.geschwindischkeiterhohen(input));

        }
    }
}
