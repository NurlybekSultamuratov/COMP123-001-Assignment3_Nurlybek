using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Name: Nurlybek Sultamuratov
/// Student number: 301103746
/// Date Last Modified 23.07.2020
/// Revision History: project is created on 21 and pushed to the Github
/// The same day coding is finished.
/// On Thursday(23.07.2020) I made documentation of my program.
/// </summary>
namespace COMP123_001_Assignment3_Nurlybek
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Mars",24.05,300.00,"Gas");
            Console.WriteLine(giantPlanet.ToString());
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Jupiter",999,400,false);
            Console.WriteLine(terrestrialPlanet.ToString());
            waitForAnyKey();
            

        }
        static void waitForAnyKey()
        {
            Console.ReadKey();
        }
    }
}
