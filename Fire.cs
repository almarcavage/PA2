using System;
namespace PA2
{
    public class Fire : IAttack
    {
        public void Attack(Character me, Character opponent)
        {
            Console.WriteLine(me.Name + " hit you with fire");
            int attackPower;
            if(opponent.GetType().ToString() == "PA2.EarthCharacter")
            {
                attackPower = me.AttackPower + 5;
            }
            else
            {
                attackPower = me.AttackPower;
            }
            opponent.Defend(attackPower);
        }
    }
}