using System;

namespace PA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Character fireGuy = new FireCharacter(){Name = "Fire Fighter"};
            Character earthGuy = new EarthCharacter(){Name = "Planet Earth"};

            Console.WriteLine("Our Characters are:");
            fireGuy.Stats();
            earthGuy.Stats();

            fireGuy.attackBehavior.Attack(fireGuy, earthGuy);
            earthGuy.Stats();

            Console.WriteLine("\n\n");
            earthGuy.attackBehavior.Attack(earthGuy, fireGuy);
            fireGuy.Stats();

        }
    }
}
