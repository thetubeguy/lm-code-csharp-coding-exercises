﻿using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Capitalises the first letter of the input string and returns the result

            return string.Concat(word[0].ToString().ToUpper(), word[1..]);

        }

        public string GenerateInitials(string firstName, string lastName)
        {
            // Returns initials separated by a full stop character

            return string.Concat(firstName[0], ".", lastName[0]);
        }

        public double AddVat(double originalPrice, double vatRate)
        {
           // Returns the price with VAT added, rounded to 2 dp

            return Math.Round(originalPrice + ((vatRate/100) * originalPrice),2);
        }

        public string Reverse(string sentence)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }

        public int CountLinuxUsers(List<User> users)
        {
            // Replace the exception statement below with your code!
            throw new NotImplementedException();
        }
    }
}
