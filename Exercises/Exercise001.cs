using Exercises.Models;
using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            return char.ToUpper(word[0]) + word[1..];
        }

        public string GenerateInitials(string firstName, string lastName)
        {

            return firstName[0] + "." + lastName[0];
        }

        public double AddVat(double originalPrice, double vatRate)
        {
            const int decimalPlaces = 2;

            return Math.Round(originalPrice + ((vatRate / 100) * originalPrice), decimalPlaces);
        }

        public string Reverse(string sentence)
        {
            char[] sentenceArray = sentence.ToCharArray();
            Array.Reverse(sentenceArray);

            return new string(sentenceArray);

        }

        public int CountLinuxUsers(List<User> users)
        {
            return users.FindAll(user => user.Type == "Linux").Count;

        }
    }
}
