using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {

        static void Main(string[] args)
        {
            GiantPlanet gp1 = new GiantPlanet("b612", 100, 200, "ice");
            Console.WriteLine(gp1);

            TerrestrialPlanet tp1 = new TerrestrialPlanet("t612", 300, 400, true);
            Console.WriteLine(tp1);

            waitForAnyKey();
        }

        public static void waitForAnyKey()
        {
            Console.WriteLine("Press any key to exit...!");
            Console.ReadKey();
        }
    }
}
