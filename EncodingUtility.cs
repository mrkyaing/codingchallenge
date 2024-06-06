namespace CodingChallenge
{
    public class EncodingUtility
    {
        //keypad dictionary for inputed digit(s) to corrected english alphabet
        private static readonly Dictionary<char, string> _keypadMapping = new Dictionary<char, string>{
                        {'1', "&\'("},
                        {'2', "abc"},
                        {'3', "def"},
                        {'4', "ghi"},
                        {'5', "jkl"},
                        {'6', "mno"},
                        {'7', "pqrs"},
                        {'8', "tuv"},
                        {'9', "wxyz"},
                        {'0', " "},
                        {'*', " "},
                    };

        /// <summary>
        ///Encoding process from the inputed (digital numbers)  to string (english alphabet)
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return lists of english alphabet according to keypad dictionary value(s). </returns>
        public static List<string> OldPhonePad(string input)
        {
            input = input.Replace("#", "");
            var results = new List<string>();

            if (string.IsNullOrEmpty(input))
            {
                return results;
            }
            //generate words according to input digits.
            results = GenerateWords(input);
            return results;
        }
        /// <summary>
        /// Generate the alphabest from digits according to keypad dictionary value(s). 
        /// </summary>
        /// <param name="digits"></param>
        /// <returns>Return lists of english alphabet by the occurrence of digit(s) in keypad dictionary source with group by approach.</returns>
        private static List<string> GenerateWords(string digits)
        {
            var alphabest = new List<string>();
            try
            {
                if (0 == digits.Length)
                {
                    return alphabest;
                }

            StarOccurrence:
                {
                    int indexOfStar = digits.IndexOf('*');
                    if (indexOfStar > 0)
                    {
                        digits = ReplaceCharAtIndex(digits, indexOfStar, ' ');
                        digits = digits.Remove(indexOfStar - 1, 1);
                        if (digits.Contains('*')) goto StarOccurrence;
                    }
                }
                string[] splittedDigits = digits.Split(' ');
                foreach (string digit in splittedDigits)
                {
                    var occurenceModels = digit.ToList().GroupBy(c => c).Select(c => new OccurenceModel(c.Key, c.Count()));
                    foreach (var occurence in occurenceModels)
                    {
                        char[] results = _keypadMapping[occurence.Digit].ToArray();
                        alphabest.Add(results[occurence.Count - 1].ToString().ToUpper());
                    }
                }
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            return alphabest;
        }

        /// <summary>
        /// encapsulated method for replacing the charactor for specific position and new charactor.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="index"></param>
        /// <param name="newChar"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
      private  static string ReplaceCharAtIndex(string input, int index, char newChar)
        {
            if (index < 0 || index >= input.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            // Replace the character at the specified index
            return input.Substring(0, index) + newChar + input.Substring(index + 1);
        }
    }
}