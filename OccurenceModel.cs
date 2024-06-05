
namespace CodingChallenge
{
    public class OccurenceModel
    {
        public char Digit { get; set; }
        public int Count { get; set; }

        public OccurenceModel(char digit,int count)
        {
            this.Digit = digit;
            this.Count = count;
        }
    }
}
