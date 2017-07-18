using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Author : Jonghyun oh
/// Std# : 300921985
/// Class : COMP123 - Programming2
/// Last modified : 2017-July-18
/// </summary>
namespace Assignment4
{
    class Program
    {
        /// <summary>
        /// main method, drive tests for classes.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            GiantPlanet gp1 = new GiantPlanet("b612", 100, 200, "ice");
            Console.WriteLine(gp1);

            TerrestrialPlanet tp1 = new TerrestrialPlanet("t612", 300, 400, true);
            Console.WriteLine(tp1);

            waitForAnyKey();
        }

        /// <summary>
        /// To wait for a key by user to prevent window closing.
        /// </summary>
        public static void waitForAnyKey()
        {
            Console.WriteLine("Press any key to exit...!");
            Console.ReadKey();
        }
    }
}
