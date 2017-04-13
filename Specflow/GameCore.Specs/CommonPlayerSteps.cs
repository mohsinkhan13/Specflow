using TechTalk.SpecFlow;

namespace GameCore.Specs
{
    [Binding]
    public class CommonPlayerSteps
    {
        public CommonPlayerSteps(PlayerCharacterStepsContext context)
        {
            _context = context;
        }
        private PlayerCharacterStepsContext _context;

        [Given(@"I am a new player")]
        public void GivenIAmANewPlayer()
        {
            _context.Player = new PlayerCharacter();
        }

    }
}
