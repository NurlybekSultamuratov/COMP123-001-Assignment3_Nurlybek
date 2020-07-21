using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_001_Assignment3_Nurlybek
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Mars",24.05,300.00,"Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Upiter",999,400,true);
            Console.WriteLine(terrestrialPlanet.ToString());
            waitForAnyKey();
            

        }
        static void waitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
