using System;
using System.Collections.Generic;
using System.Text;

namespace MagicalInheritance
{
    class Pupil
    {
        public string Title
        { get; private set; }

        //constructor that is setting the Title
        public Pupil(string title)
        {
            Title = title;
        }

        //pupil  
        //creating a new storm object and returning it
        public Storm CastWindStorm()
        {
            return new Storm("wind", false, Title);

        }
    }
}
