using System.Collections.Generic;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            const int NUM_LETTERS_IN_ALPHABET = 26;

            List<char> letterList = new List<char>();

            foreach (char thisChar in input)
            {
                if (char.IsLetter(thisChar))
                {
                    char upperChar = char.ToUpper(thisChar);
                    if (!letterList.Contains(upperChar))
                    {
                        letterList.Add(upperChar);
                    }
                }
            }
            return (letterList.Count == NUM_LETTERS_IN_ALPHABET);

        }
    }
}
