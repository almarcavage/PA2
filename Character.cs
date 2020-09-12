using System;
namespace PA2
{
    public class Character
    {
        public string Name {get; set;}
        public int MaxPower {get; set;}
        public int Health {get; set;}
        public int AttackPower {get; set;}
        public int DefensePower {get; set;}

        public IAttack attackBehavior;
        public IDefend defenseBehavior;

        public Character()
        {
            var rand = new Random();
            MaxPower = rand.Next(99) + 1;
            Health = 100;
            AttackPower = rand.Next(MaxPower) + 1;
            DefensePower = rand.Next(MaxPower) + 1;
            defenseBehavior = new BasicDefense();
        }

        public void SetAttackBehavior(IAttack value)
        {
            attackBehavior = value;
        }

        public void SetDefenseBehavior(IDefend value)
        {
            defenseBehavior = value;
        }

        public void Defend(int power)
        {
            power = defenseBehavior.Defend(power);
            Health -= power;
            Console.WriteLine($"{power} damage done to {this.Name}");
        }

        public void Stats()
        {
            Console.WriteLine($"{Name} has: \n{Health} Health\n{AttackPower} Attack Power\n{DefensePower} Defense Power");
        }
    }
}