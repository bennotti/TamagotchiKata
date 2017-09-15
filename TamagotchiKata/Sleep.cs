namespace TamagotchiKata
{
    public class Sleep : Needs
    {
        public override void SendingNeeds()
        {
            Tiredness = Decrease(Tiredness);
        }
    }
}
