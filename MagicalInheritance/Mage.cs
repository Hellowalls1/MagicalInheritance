using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalInheritance
{
    class Mage : Pupil
    {

        //Mage constructor that is inheriting title from pupil constructor. Do not need to do Title=title already done in base
        public Mage(string title) : base(title)
        { }

        //new method that has a return type of storm
        //since it will be overridden in Archmage must be marked virtual
        public virtual Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);

        }
    }
}
