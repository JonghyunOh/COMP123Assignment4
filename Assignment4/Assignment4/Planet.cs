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
    public abstract class Planet
    {
        /// <summary>
        /// member variables for Planet.
        /// </summary>
        private readonly double _diameter;
        private readonly double _mass;
        private int _moonCount;
        private readonly string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        /// <summary>
        /// Constructor with 3 arguments.
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="p_diameter"></param>
        /// <param name="p_mass"></param>
        public Planet(string p_name, double p_diameter, double p_mass)
        {
            this._name = p_name;
            this._diameter = p_diameter;
            this._mass = p_mass;
        }


        /// <summary>
        /// ToString() method is overrided to show member variables(name, diameter, mass).
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("NameOfPlanet : {0} // Diameter : {1} // Mass : {2} ", _name, _diameter, _mass); ;
        }


        public double Diameter
        {

            get
            {
                return this._diameter;
            }
        }

        public double Mass
        {

            get
            {
                return this._mass;
            }
        }

        public int MoonCount
        {

            get
            {
                return this._moonCount;
            }

            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {

            get
            {
                return this._name;
            }
        }

        public double OrbitalPeriod
        {

            get
            {
                return this._orbitalPeriod;
            }

            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {

            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {

            get
            {
                return this._rotationPeriod;
            }

            set
            {
                this._rotationPeriod = value;
            }
        }



    }
}
