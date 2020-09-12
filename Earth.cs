using System;
namespace PA2
{
    public class Earth : IAttack
    {
        public void Attack(Character me, Character opponent)
        {
            Console.WriteLine(me.Name + " hit you with earth");
            opponent.Defend(me.AttackPower);
        }
        
    }
}