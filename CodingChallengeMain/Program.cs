namespace CodingChallenge;
class Program
{
    private readonly static string CHOICE_KEY = "y";
    static void Main(string[] args)
    {
        Console.WriteLine("Hello,Coding Chellengance!");
        try
        {
            bool isNextTime = false;
            string nextTime = null;
            Console.Write("Please type digit(s):");
            string inputDigits = Console.ReadLine();
            do
            {
                var results = EncodingUtility.OldPhonePad(inputDigits);
                if (results.Any())
                {
                    Console.Write("Output result(s): ");
                    foreach (var word in results)
                    {
                        Console.Write(word);
                    }
                    Console.WriteLine();
                }
                Console.Write("Do you try next time?, then type (y):");
                nextTime = Console.ReadLine();
                if (CHOICE_KEY.Equals(nextTime))
                {
                    Console.Write("Please type digit(s):");
                    inputDigits = Console.ReadLine();
                    isNextTime = true;
                }
                else
                    isNextTime = false;
            } while (isNextTime);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Oh!!Sorry,Invalid Process");
        }
        finally
        {
            Console.WriteLine("Happy ending,program finished!!");
        }
    }
}
