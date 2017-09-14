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
            var increase = 6;
            var decrease = 4;

            tamagotchi.Feed();

            increase.Should().BeGreaterOrEqualTo(tamagotchi.Fullness);
            decrease.Should().BeLessOrEqualTo(tamagotchi.Hungriness);
        }

        [Test]
        public void BeMoreTiredAndMoreHappierWhenWePlayWithHim()
        {
            var tamagotchi = new Tamagotchi();
            var increase = 6;

            tamagotchi.Play();

            increase.Should().BeGreaterOrEqualTo(tamagotchi.Happiness);
            increase.Should().BeGreaterOrEqualTo(tamagotchi.Tiredness);
        }
    }

    public class Tamagotchi
    {
        public int Hungriness;
        public int Fullness;
        public int Happiness;
        public int Tiredness;

        public Tamagotchi()
        {
            Hungriness = 5;
            Fullness = 5;
            Happiness = 5;
            Tiredness = 5;
        }

        public void Feed()
        {
            Hungriness -= 1;
            Fullness += 1;
        }

        internal void Play()
        {
            Happiness += 1;
            Tiredness += 1;
        }
    }
}
