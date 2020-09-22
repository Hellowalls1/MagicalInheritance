using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Magical Inheritance. A place where magical beings do some crazy shit.");
            Console.WriteLine("Are you ready to rumble? Enter yes or no.");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "no")
            {
                Console.WriteLine("Your presense is not needed plebe! Go back to the village from whenst you came!");
            }
            else
            {
                Console.WriteLine("Are you a Mage, Archmage, or Pupil? Please enter one.");
                string userTypeChoice = Console.ReadLine();

               
                  //  case 1:
                  //  Console.WriteLine("Case 1");
                  //  break;
                    //creating a new Pupil class which sets the title
                    Pupil p = new Pupil("Mezil-kree");

                //creating a new Storm class and giving it the value of a pupil (p) with the parameters that CastWindStorm holds in the Pupil class

                Storm windStorm = p.CastWindStorm();

                //announcing the windstorm utilizing the parameter values from CastWindStorm
                Console.WriteLine(windStorm.Announce());

                Mage m = new Mage("Gul'dan");
                Storm mageWindStorm = m.CastWindStorm();
                Storm rainStorm = m.CastRainStorm();
                Console.WriteLine(mageWindStorm.Announce());
                Console.WriteLine(rainStorm.Announce());

                Archmage am = new Archmage("Nielas Aran");
                Storm amRainStorm = am.CastRainStorm();
                Storm lightningStorm = am.CastLightningStorm();
                Storm amWindStorm = am.CastWindStorm();
                Console.WriteLine(amWindStorm.Announce());
                Console.WriteLine(amRainStorm.Announce());
                Console.WriteLine(lightningStorm.Announce());
            }
        }
    }
}
