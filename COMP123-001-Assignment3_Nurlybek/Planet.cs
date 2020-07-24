using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_001_Assignment3_Nurlybek
{
    //ABSTRACT CLASS PLANET
    abstract public class Planet
    {

        //PRIVATE FIELDS

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;


        //PUBLIC PROPERTIES

        public double Diameter
        {
            get => _diameter;
        }

        public double Mass
        {
            get => _mass;
        }

        public int MoonCount
        {
            get => _moonCount;
            set
            {
                _moonCount = value;
            }
        }

        public string Name
        {
            get => _name;
        }

        public double OrbitalPeriod
        {
            get => _orbitalPeriod;
            set
            {
                _orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get => _ringCount;
            set
            {
                _ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get => _rotationPeriod;
            set
            {
                _rotationPeriod = value;
            }
        }


        //CONSTRUCTOR

        /// <summary>
        /// This constructor passes parameters to the child classes
        /// Assings its parameters to private fields
        /// </summary>
        /// <param name="name"></param>
        /// <param name="diameter"></param>
        /// <param name="mass"></param>
         public Planet (string name, double diameter, double mass)
        {

            this._name = name;
            this._diameter = diameter;
            this._mass = mass;

           
        }

        //OVERRIDE STRING METHOD
        /// <summary>
        /// This ToString method is needed to override and display output to the console
        /// It displays Name , Diameter and Mass of the Planet.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {Name}, Diameter: {Diameter}, Mass: {Mass}";
        }
    }
}