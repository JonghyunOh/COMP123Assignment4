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
    class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        private bool _oxygen = false;

        public TerrestrialPlanet(string p_name, double p_diameter, double p_mass, bool oxygen) : base(p_name, p_diameter, p_mass)
        {
            this._oxygen = oxygen;
        }

        public bool HasMoons()
        {
            bool result = false;

            if(this.MoonCount > 0)
            {
                result = true;
            }

            return result;
        }

        public bool Habitable()
        {
            return this._oxygen;
        }
    }
}
