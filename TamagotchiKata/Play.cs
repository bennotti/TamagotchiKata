namespace TamagotchiKata
{
    public class Play : Needs
    {
        public override void SendingNeeds()
        {
            Tiredness = Increase(Tiredness);
            Happiness = Increase(Happiness);
        }
    }
}
