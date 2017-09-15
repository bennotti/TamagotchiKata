namespace TamagotchiKata
{
    public class Feed : Needs
    {
        public override void SendingNeeds()
        {
            Hungriness = Decrease(Hungriness);
            Fullness = Increase(Fullness);
        }
    }
}
