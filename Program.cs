using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrrad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrrad BMX = new Fahrrad();
            reifen vorne = new reifen();
            reifen hinter = new reifen();
            Random random = new Random();
            int zeit = random.Next(200,303);
            BMX.Setvorderreifen(vorne);
            BMX.SetHiterreifen(hinter);
            Console.WriteLine("geb die grosse ein:");
            BMX.Getvorderreifen().SetGrosse(Convert.ToInt32(Console.ReadLine()));
            BMX.Getvorderreifen().Talkabutyourself();
            BMX.GetHiterreifen().Talkabutyourself();
            BMX.GetHiterreifen().GeplatzterReifen(zeit);
            Console.WriteLine(BMX.GetHiterreifen());
            Console.WriteLine(BMX.Getvorderreifen());



        }
    }
}
