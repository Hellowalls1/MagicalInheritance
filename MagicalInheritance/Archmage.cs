using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        {}

        public override Storm CastRainStorm()
        {
            return new Storm("rain", false, Title);
        }
        public Storm CastLightningStorm()
        {
            return new Storm("lightning", true, Title);
        }
    }
}
