using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird ()
        {
            NumberOfLegs = 2;
            ScalesFurFeathers = "Feathers";
            Sound = "Tweet Tweet";
            BigSmallMedium = "Medium";
        }

        public bool CanFly { get; set; }
        public string Breed { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        // Create a class Bird
        // give this class 4 members that are specific to Bird
        // Set this class to inherit from your Animal Class
    }
    
}
