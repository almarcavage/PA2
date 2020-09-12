namespace PA2
{
    public class FireCharacter : Character
    {
        public FireCharacter() : base()
        {
            SetAttackBehavior(new Fire());
        }
    }
}