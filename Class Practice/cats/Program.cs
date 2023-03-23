using System;

namespace Cats
{
    class Program
    {
        static void Main(string[]args)
        {
            //Try out your skills with inheritance here
            HouseCat spike = new HouseCat("Spike", 12.0);
            spike.Eat();
            Console.WriteLine(spike.Tired);
            Console.WriteLine(spike.Name);
            Console.WriteLine("The name of the cat is " + spike.Name + ". Is the cat tired? " + spike.Tired );

            HouseCat spot = new HouseCat("Spot", 12);
            Console.WriteLine("The name of the other cat is " + spot.Name + " and she weighs " + spot.Weight + " pounds.");
        }
    }
}