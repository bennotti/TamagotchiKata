namespace TamagotchiKata
{
    public class TimePasses : Needs
    {
        public override void SendingNeeds()
        {
            Tiredness = Increase(Tiredness);
            Hungriness = Increase(Hungriness);
            Happiness = Decrease(Happiness);
        }
    }
}
