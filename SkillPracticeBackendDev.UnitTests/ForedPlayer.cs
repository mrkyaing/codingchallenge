using SkillPracticeBackendDev.DI;

namespace SkillPracticeBackendDev.UnitTests
{
    internal class ForedPlayer : IPlayer
    {
        private readonly Choice _choice;

        public ForedPlayer(Choice choice)
        {
            this._choice = choice;
        }
        public Choice GetChoice()
        {
            return _choice;
        }
    }
}
