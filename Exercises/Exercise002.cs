using System;
using Exercises.Models;

namespace Exercises
{
    public class Exercise002
    {
        public bool IsFromManchester(Person person)
        {
            if (person.City == "Manchester")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CanWatchFilm(Person person, int ageLimit)
        {
            if (person.Age >= ageLimit)
                return true;
            else
                return false;
        }
    }
}
