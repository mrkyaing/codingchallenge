namespace CodingChallenge
{
    public class EncodingUtility
    {
        //keypad string[] for inputed digit(s) to corrected English alphabet
       private static readonly string[] _keypad = {
                                                                        "",     // 0
                                                                        "&\'(", // 1
                                                                        "abc",  // 2
                                                                        "def",  // 3
                                                                        "ghi",  // 4
                                                                        "jkl",  // 5
                                                                        "mno",  // 6
                                                                        "pqrs", // 7
                                                                        "tuv",  // 8
                                                                        "wxyz"  // 9
                                                                    };

        /// <summary>
        ///Mapping process from the inputed (digital numbers)  to string (English alphabet).
        /// </summary>
        /// <param name="input"></param>
        /// <returns>Return string value(s) of English alphabet according to keypad dictionary value(s). </returns>
        public static string OldPhonePad(string input)
        {
            input = input.Replace("#", "");
            string results = null;

            if (string.IsNullOrEmpty(input))
            {
                return results;
            }
            //generate words according to input digits.
            results = GenerateWords(input);
            return results.ToUpper();
        }
        /// <summary>
        /// Generate the alphabets from digits according to keypad dictionary value(s).
        /// </summary>
        /// <param name="digits"></param>
        /// <returns>Return string of English alphabet by the occurrence of digit(s) in keypad string array source with deleting process when occurs in * char at input string.</returns>
        public static string GenerateWords(string digits)
        {
            var alphabest = new List<char>();
            int index = 0;
            //looping through for all input digits
            while (index < digits.Length)
            {
                //if input character is * ,then remove before of it .
                if ('*'.Equals(digits[index]))
                {
                    if (alphabest.Count > 0)
                    {
                        alphabest.RemoveAt(alphabest.Count - 1);
                    }
                    index++;
                }
                else
                {
                    //if input character is ' ' ,then not check in the _keypad[] and skip this character.
                    if (' '.Equals(digits[index]))
                    {
                        index++;
                        continue;
                    }
                    int digit = digits[index] - '0';
                    string letters = _keypad[digit];

                    if (!string.IsNullOrEmpty(letters))
                    {
                        int maxPresses = letters.Length;
                        int count = 1;
                        //increase the count to get the character with related index
                        while (index + count < digits.Length && digits[index + count] == digits[index] && count < maxPresses)
                        {
                            count++;
                        }
                        //adding the char to the char[] to response.
                        alphabest.Add(letters[count - 1]);
                        index += count;
                    }
                    else
                    {
                        index++;
                    }
                }
            }
            return new string(alphabest.ToArray());
        }
    }
}