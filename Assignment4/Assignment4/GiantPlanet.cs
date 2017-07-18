using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type = "Gas";


        public GiantPlanet(string p_name, double p_diameter, double p_mass, string type) : base(p_name, p_diameter, p_mass)
        {
            if (type.ToLower().Equals("ice"))
            {
                this._type = "Ice";
            }
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
