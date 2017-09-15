using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamagotchiKataTest
{
    [TestFixture]
    class TamagotchiShould
    {
        [Test]
        public void BeMoreFullnessAndHaveLessStarvingWhenWeFeedHim()
        {
            var tamagotchi = new Tamagotchi();

            var needs = tamagotchi.Feed();

            needs.Fullness.Should().BeGreaterThan(10);
            needs.Hungriness.Should().BeLessThan(10);
        }

        [Test]
        public void BeMoreTiredAndMoreHappierWhenWePlayWithHim()
        {
            var tamagotchi = new Tamagotchi();

            var needs = tamagotchi.Play();

            needs.Tiredness.Should().BeGreaterThan(10);
            needs.Happiness.Should().BeGreaterThan(10);
        }

        [Test]
        public void BeLessTiredWhenWePuttingInBed()
        {
            var tamagotchi = new Tamagotchi();

            var needs = tamagotchi.Sleep();

            needs.Tiredness.Should().BeLessThan(10);
        }

        [Test]
        public void BeLessFullnessWhenWeMakePoop()
        {
            var tamagotchi = new Tamagotchi();

            var needs = tamagotchi.MakeAPoop();

            needs.Fullness.Should().BeLessThan(10);
        }

        [Test]
        public void BeMoreTiredAndMoreStarveAndLessHappierWhenTheTimePasses()
        {
            var tamagotchi = new Tamagotchi();

            var needs = tamagotchi.TimePassed();

            needs.Tiredness.Should().BeGreaterThan(10);
            needs.Hungriness.Should().BeGreaterThan(10);
            needs.Happiness.Should().BeLessThan(10);
        }
    }

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

    public class TimePasses : Needs
    {
        public override void SendingNeeds()
        {
            Tiredness = Increase(Tiredness);
            Hungriness = Increase(Hungriness);
            Happiness = Decrease(Happiness);
        }
    }

    public class MakeAPoop : Needs
    {
        public override void SendingNeeds()
        {
            Fullness = Decrease(Fullness);
        }
    }

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

    public class Feed : Needs
    {
        public override void SendingNeeds()
        {
            Hungriness = Decrease(Hungriness);
            Fullness = Increase(Fullness);
        }
    }

    public class Play : Needs
    {
        public override void SendingNeeds()
        {
            Tiredness = Increase(Tiredness);
            Happiness = Increase(Happiness);
        }
    }

    public class Sleep : Needs
    {
        public override void SendingNeeds()
        {
            Tiredness = Decrease(Tiredness);
        }
    }
}
