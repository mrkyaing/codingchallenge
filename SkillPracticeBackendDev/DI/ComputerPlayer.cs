namespace SkillPracticeBackendDev.DI
{
    internal class ComputerPlayer : IPlayer
    {
        Random rdn=new Random();
        public Choice GetChoice()
        {
            Choice p2 = (Choice)rdn.Next(0, 3);
            return p2;
        }
    }
}
