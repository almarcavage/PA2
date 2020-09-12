namespace PA2
{
    public class EarthCharacter : Character
    {
        public EarthCharacter() : base()
        {
            SetAttackBehavior(new Earth());
        }
    }
}