using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            double gigaSec = Math.Pow(10,9);  //Would be better to make this constant for execution speed
            DateTime newdateTime;

            newdateTime = dateTime.AddSeconds(gigaSec);

            return newdateTime;
        }
    }
}
