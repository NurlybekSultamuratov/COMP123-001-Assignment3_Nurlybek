using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_001_Assignment3_Nurlybek
{
    public class TerrestrialPlanet: Planet , IHasMoons, IHabitable
    {
        private bool _oxygen;

        public bool Habitable()
        {
         if (_oxygen == true)
            {
                return true;
            }
         else
            {
                return false;
            }
        }

        public bool HasMoons()
        {
           if(MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen):
             base (name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
    }
}