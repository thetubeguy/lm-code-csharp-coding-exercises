using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            ulong gigaSec = ((ulong)Math.Pow(10,9));  //Would be better to make this constant for execution speed
            DateTime newdateTime;
            TimeSpan myspan = TimeSpan.FromSeconds(gigaSec);

            DateTime maxdate = DateTime.MaxValue - myspan;

            if (dateTime <= maxdate)
            {
                newdateTime = dateTime.AddSeconds(gigaSec);
            }
            else
            {
                newdateTime = new DateTime(0001, 1, 1, 0, 0, 0, 0);
            }
 
            return newdateTime;
        }
    }
}
