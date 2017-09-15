namespace TamagotchiKata
{
    public class MakeAPoop : Needs
    {
        public override void SendingNeeds()
        {
            Fullness = Decrease(Fullness);
        }
    }
}
