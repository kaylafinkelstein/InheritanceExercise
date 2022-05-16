using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var penguin = new Bird();
            penguin.CanFly = false;
            penguin.Size = "3 feet";
            penguin.Color = "black and white";
            penguin.Breed = "Gentoo";

            var crocodile = new Reptile();
            crocodile.Age = 30;
            crocodile.TeethCount = 110;
            crocodile.Size = "17 feet";
            crocodile.LifeSpan = "60-70 years";

            var myAnimal = new Animal[] { penguin, crocodile };
            foreach(var animal in myAnimal)
            {
                Console.WriteLine($"How many legs does it have? {animal.NumberOfLegs}");
                Console.WriteLine($"Does it have scales, feathers, or fur?: {animal.ScalesFurFeathers}");
                Console.WriteLine($"Sound it makes: {animal.Sound}");
                Console.WriteLine($"Size of animal: {animal.BigSmallMedium}");
                Console.WriteLine("");
            }



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
