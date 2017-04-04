using System;
using TechTalk.SpecFlow;
using Xunit;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private PlayerCharacter _player;

        [Given(@"I am a new player")]
        public void GivenIAmANewPlayer()
        {
            _player = new PlayerCharacter();
        }
        
        [When(@"I take 0 damage")]
        public void WhenITake0Damage()
        {
            _player.Hit(0);
        }
        
        [Then(@"my health should be 100")]
        public void ThenMyHealthShouldBe100()
        {
            Assert.Equal(100, _player.Health);
        }

        [When(@"I am hit by 10 damage")]
        public void WhenIAmHitBy10Damage()
        {
            _player.Hit(10);
        }

        [Then(@"My health should reduce to 90")]
        public void ThenMyHealthShouldReduceTo90()
        {
            Assert.Equal(90, _player.Health);
        }




        [When(@"I am hit by 90 damage")]
        public void WhenIAmHitBy90Damage()
        {
            _player.Hit(90);
        }

        [Then(@"My health should reduce to 0")]
        public void ThenMyHealthShouldReduceTo0()
        {
            Assert.Equal(0, _player.Health);
        }

        [Then(@"I should be dead")]
        public void ThenIShouldBeDead()
        {
            Assert.Equal(true, _player.IsDead);
        }


    }
}
