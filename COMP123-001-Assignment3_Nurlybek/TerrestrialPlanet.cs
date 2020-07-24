using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_001_Assignment3_Nurlybek
{
    public class TerrestrialPlanet: Planet , IHasMoons, IHabitable
    {
        //PRIVATE FIELDS 

        private bool _oxygen;

        //PUBLIC METHODS
        /// <summary>
        /// Habitable method checks if there's oxygen and returns its value
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// HasMoons method checks if MoonCount is greater than 0 it returns true
        /// </summary>
        /// <returns></returns>
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

        //CONSTRUCTOR

        /// <summary>
        /// this constructor is derived class that inherits from Planet class
        /// it adds and assigns bool oxygen to the private field
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="oxygen"></param>
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen):
             base (name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
    }
}