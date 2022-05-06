using System.Collections.Generic;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            const int NUM_LETTERS_IN_ALPHABET = 26;

            List<char> letterlist = new List<char>();

            foreach (char thischar in input)
            {
                if (char.IsLetter(thischar))
                {
                    char upperchar = char.ToUpper(thischar);
                    if (!letterlist.Contains(upperchar))
                        letterlist.Add(upperchar);
                }
            }
            return (letterlist.Count == NUM_LETTERS_IN_ALPHABET);
            
        }
    }
}
