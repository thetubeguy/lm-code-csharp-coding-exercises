using System.Collections.Generic;
using System;
using System.Linq;

namespace Exercises
{
    public class Exercise005
    {
        public bool IsPangram(string input)
        {
            String alphabet = "abcdefghijklmnopqrstuvwxyz";

            return alphabet.All(l => input.ToLower().Contains(l));

        }
    }
}
