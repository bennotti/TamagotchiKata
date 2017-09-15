namespace TamagotchiKata
{
    public abstract class Needs
    {
        public int Hungriness  { get; protected set; }
        public int Fullness    { get; protected set; }
        public int Happiness   { get; protected set; }
        public int Tiredness   { get; protected set; }

        public Needs()
        {
            Hungriness = 10;
            Fullness = 10;
            Happiness = 10;
            Tiredness = 10;
        }

        public abstract void SendingNeeds();

        protected int Increase(int mood)
        {
            return mood += 1;
        }

        protected int Decrease(int mood)
        {
            return mood -= 1;
        }
    }
}
