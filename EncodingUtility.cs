namespace CodingChallenge
{
    public class EncodingUtility
    {
        private static readonly Dictionary<char, string> keypadMapping = new Dictionary<char, string>{
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
        /// <returns></returns>
        public static List<string> OldPhonePad(string input)
        {
            input = input.Replace("#", "");
            var results = new List<string>();

            if (string.IsNullOrEmpty(input))
            {
                return results;
            }

            results = GenerateWords(input);
            return results;
        }
        /// <summary>
        /// Generate the alphabest from digits according to dictionary source 
        /// </summary>
        /// <param name="digits"></param>
        /// <returns>List of alphabet </returns>
        private static List<string> GenerateWords(string digits)
        {
            var alphabest = new List<string>();
            if (0 == digits.Length)
            {
                return alphabest;
            }
          
        starOccurence: {
                int indexOfStar = digits.IndexOf('*');
                if (indexOfStar > 0)
                {
                    digits= ReplaceCharAtIndex(digits, indexOfStar, ' ');
                    digits = digits.Remove(indexOfStar - 1, 1);
                    if (digits.Contains('*')) goto starOccurence;
                }
            }
            string[] splittedDigit = digits.Split(' ');
            foreach (string digit in splittedDigit)
            {
                var occurenceModels = digit.ToList().GroupBy(c => c).Select(c => new OccurenceModel(c.Key, c.Count()));
                foreach (var occurence in occurenceModels)
                {
                    char[] results = keypadMapping[occurence.Digit].ToArray();
                    alphabest.Add(results[occurence.Count - 1].ToString().ToUpper());
                }
            }
            return alphabest;
        }
        static string ReplaceCharAtIndex(string input, int index, char newChar)
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