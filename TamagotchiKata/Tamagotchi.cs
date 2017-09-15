namespace TamagotchiKata
{
    public class Tamagotchi
    {
        private Needs _needs;

        public Tamagotchi() {}

        public Needs Feed()
        {
            _needs = new Feed();
            _needs.SendingNeeds();

            return _needs;
        }

        public Needs Play()
        {
            _needs = new Play();
            _needs.SendingNeeds();

            return _needs;
        }

        public Needs Sleep()
        {
            _needs = new Sleep();
            _needs.SendingNeeds();

            return _needs;
        }

        public Needs MakeAPoop()
        {
            _needs = new MakeAPoop();
            _needs.SendingNeeds();

            return _needs;
        }

        public Needs TimePassed()
        {
            _needs = new TimePasses();
            _needs.SendingNeeds();

            return _needs;
        }
    }
}
