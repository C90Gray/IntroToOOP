using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Mr. Fuzzy";

            Cat secondCat = new Cat("Midnight", 14, "Black");

            Console.WriteLine(firstCat.Name);
            Console.WriteLine(secondCat.Name);

            firstCat.Eat(); //calling the eat method on the firstcat object
            secondCat.Meow();

            Dog scruffy = new Dog();
            scruffy.HairLength = "Longhaired";

            Console.WriteLine("Scruffy is a " + scruffy.HairLength + "dog.");
            scruffy.Bark();

            SuperHero Cletus = new SuperHero("Xray Vision", 2000, true, false);
            Console.WriteLine("Cletus is an awesome superhero with " + Cletus.SuperPower);

            Cletus.BattleCry();






        

        }
    }
}
