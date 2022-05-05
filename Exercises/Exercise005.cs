using System;
using System.Collections.Generic;
namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            List<char> letterlist = new List<char>();
            char upperchar = '-';
            foreach (char thischar in input)
            {
                if (Char.IsLetter(thischar))
                {
                    upperchar = Char.ToUpper(thischar);
                    if (!letterlist.Contains(upperchar))
                        letterlist.Add(upperchar);
                }
            }
            if(letterlist.Count == 26)
                return true;
            else
                return false;

        }
    }
}
