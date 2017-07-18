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
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type = "Gas";

        /// <summary>
        /// Constructor has 4 arguments below
        /// Type must be "Gas" or "Ice"
        /// </summary>
        /// <param name="p_name"></param>
        /// <param name="p_diameter"></param>
        /// <param name="p_mass"></param>
        /// <param name="type"></param>
        public GiantPlanet(string p_name, double p_diameter, double p_mass, string type) : base(p_name, p_diameter, p_mass)
        {
            if (type.ToLower().Equals("ice"))
            {
                this._type = "Ice";
            }
        }

        
        /// <summary>
        /// If MoonCount is greater than 0, it returns true.
        /// </summary>
        /// <returns></returns>
        public bool HasMoons()
        {
            bool result = false;

            if(this.MoonCount > 0)
            {
                result = true;
            }

            return result;
        }

        /// <summary>
        /// If RingCount is greater than 0, it returns true.
        /// </summary>
        /// <returns></returns>
        public bool HasRings()
        {
            bool result = false;

            if(this.RingCount > 0)
            {
                result = true;
            }

            return result;
        }


    }
}
