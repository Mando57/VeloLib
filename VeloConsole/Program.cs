using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeloLib;

namespace VeloConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            VeloElectrique standard = new VeloElectrique();
            Console.WriteLine("On peut encore parcourir " + standard.autonomieKm(25) + "km");
            standard.rouler(25, 10);
            Console.WriteLine("On peut encore parcourir " + standard.autonomieKm(25) + "km");

            Console.WriteLine("----------------------------");

            VeloElectrique top = new VeloElectrique(750, 48, 10, 10, "M", "bleu", 21, 12);
            Console.WriteLine("On peut encore parcourir " + top.autonomieKm(45) + "km");
            top.rouler(45, 25);
            Console.WriteLine("On peut encore parcourir " + top.autonomieKm(45) + "km");

            top.chargerBatterie();
            Console.WriteLine("On peut faire " + top.nbTrajets(10, 45) + " trajets de 10km");

            Console.ReadKey();
        }
    }
}
