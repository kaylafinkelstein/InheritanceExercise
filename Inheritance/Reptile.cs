using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile ()
        {
            NumberOfLegs = 4;
            ScalesFurFeathers = "Scales";
            Sound = "Rwar";
            BigSmallMedium = "Big";

        }
        public int Age { get; set; }
        public int TeethCount { get; set; }
        public string Size { get; set; }
        public string LifeSpan { get; set; }

        // Create a class Reptile
        // give this class 4 members that are specific to Reptile
        // Set this class to inherit from your Animal Class
    }
}
