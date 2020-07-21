using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_001_Assignment3_Nurlybek
{
    public class GiantPlanet : Planet , IHasMoons, IHasRings
    {
        private string _type="Gas";

        public GiantPlanet (string name, double diameter, double mass, string type):
            base (name,diameter,mass)
        {
            
            this._type = type;


        }

        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
         
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}