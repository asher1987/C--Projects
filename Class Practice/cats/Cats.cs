using System;
namespace Cats
{
    public class HouseCat: Cat
    {
        public string Name {get; set;}
        public string Species {get; set;} = "Felis catus";
        

        public HouseCat(string name, double weight) : base(weight)
        {
            Name = name;
        }

        // on this line write a constructor that uses the non arg constructor in the Cat class
        public HouseCat(string name)
        {
            Name = name;
        }

        public bool isSatisfied()
        {
            return !Hungry && !Tired;
        }

        public override string Noise()
        
        {
                return "Hello, my name is " + Name + "!";
        }

        public string Purr()
        {
                return "I'm a housecat";
        }
    }
 }
