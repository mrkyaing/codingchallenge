namespace SkillPracticeBackendDev.DI
{
    internal class HumanPlayer : IPlayer
    {
        public Choice GetChoice()
        {
            Choice p1;
            do
            {
                Console.Write("Enter Choice (R)ock,(P)aper,or (S)cissors:");
                string input=Console.ReadLine().ToUpper();
                switch (input)
                {
                    case "R": p1 = Choice.Rock;return p1 ;
                    case "P":p1=Choice.Paper; return p1;
                    case "S":p1 = Choice.Scissors; return p1;
                    default:Console.WriteLine("Invalid choice,Try again"); break;
                }
            }while (true);
        }
    }
}
