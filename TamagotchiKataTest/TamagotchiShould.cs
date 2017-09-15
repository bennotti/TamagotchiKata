using FluentAssertions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamagotchiKata;

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
}
