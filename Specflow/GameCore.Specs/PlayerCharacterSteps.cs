using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps : Steps
    {
        public PlayerCharacterSteps(PlayerCharacterStepsContext context)
        {
            _context = context;
        }

        private PlayerCharacterStepsContext _context;

        [When("I take (.*) damage")]
        public void WhenITakeDamage(int damage)
        {
            if (this.ScenarioContext.ContainsKey("health"))
                _context.Player.Health = (int)ScenarioContext["health"];
            _context.Player.Hit(damage);
        }

        [When("I take (.*) damage")]
        [Scope(Tag ="Elf")]
        public void WhenITakeDamageAsAnElf(int damage)
        {
            if (this.ScenarioContext.ContainsKey("health"))
                _context.Player.Health = (int)ScenarioContext["health"];
            _context.Player.Hit(damage);
        }

        [Then(@"My health should be (.*)")]
        public void ThenMyHealthShouldBe(int health)
        {
            Assert.Equal(health, _context.Player.Health);
        }

        
        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.Equal(true, _context.Player.IsDead);
        }

        [Given(@"I have an initial resistace of (.*)")]
        public void GivenIHaveAnInitialResistaceOf(int resistance)
        {
            _context.Player.Attributes.Resistance = 10;
        }

        [Given(@"I am of Race (.*)")]
        public void GivenIAmOfRace(string race)
        {
            _context.Player.Attributes.Race = "Elf";
        }

        [Given(@"I have following attributes")]
        public void GivenIHaveFollowingAttributes(Table table)
        {
            var attributes = table.CreateInstance<PlayerAttributes>();
            _context.Player.Attributes = attributes;
        }

        [Given(@"I last slept (.* days ago)")]
        public void GivenILastSleptDaysAgo(DateTime lastSlept)
        {
            _context.Player.LastSlept = lastSlept;
        }


        [Given(@"I have following weapons")]
        public void GivenIHaveFollowingWeapons(IEnumerable<Weapon> weapons)
        {
            _context.Player.Weapons.AddRange(weapons);
        }

        [Then(@"Total value of weapons should be (.*)")]
        public void ThenTotalValueOfWeaponsShouldBe(int expectedValueOfAllWeapons)
        {
            Assert.Equal(expectedValueOfAllWeapons, _context.Player.Weapons.Sum(x => x.Value));
        }


        [Given(@"My current health is (.*)")]
        public void GivenMyCurrentHealthIs(int currentHealth)
        {
            this.ScenarioContext["health"] = currentHealth;
        }



    }
}
