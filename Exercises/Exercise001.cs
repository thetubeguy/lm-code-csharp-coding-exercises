using System;
using System.Collections.Generic;
using Exercises.Models;

namespace Exercises
{
    public class Exercise001
    {
        public string CapitalizeWord(string word)
        {
            // Capitalises the first letter of the input string and returns the result

            //return string.Concat(word[0].ToString().ToUpper(), word[1..]);
            return char.ToUpper(word[0]) + word[1..];
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
            // Strings are immutable, character arrays can be changed
            // We can apply array methods to a character array

            char[] sentenceArray =  sentence.ToCharArray();  //string has method to change to char array
            Array.Reverse(sentenceArray);

           
            return new string(sentenceArray);  //Need to use string constructor

        }

        public int CountLinuxUsers(List<User> users)
        {
            int count = 0;
            foreach (User thisUser in users)
            {
                if (thisUser.Type == "Linux") count++;  // Class User defined in Exercises.Models.User
                
            }

            return count;
        }
    }
}
