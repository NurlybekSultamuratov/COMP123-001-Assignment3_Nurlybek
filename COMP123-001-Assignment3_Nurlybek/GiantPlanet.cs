using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_001_Assignment3_Nurlybek
{
    public class GiantPlanet : Planet , IHasMoons, IHasRings
    {
        //PRIVATE FIELDS//

        private string _type;

        //PUBLIC METHODS

        /// <summary>
        /// HasMoons method checks if MoonCount is greater than 0 it returns true
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// HasRings method checks if RingCount is greater than 0
        /// returns true 
        /// </summary>
        /// <returns></returns>
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

        //CONSTRUCTOR

        /// <summary>
        /// This constructor is a subclass that is derived from Planet class
        /// adds and assigns string type Gas or Ice to the private field
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string name, double diameter, double mass, string type) :
            base(name, diameter, mass)
        {

            this._type = type;


        }
    }
}