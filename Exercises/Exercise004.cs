using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            ulong gigaSec = ((ulong)Math.Pow(10,9));  //Would be better to make this constant for execution speed
            DateTime newdateTime;
            ulong maxticks = ((ulong)DateTime.MaxValue.Ticks) - (gigaSec * 1000 * 10000);  // 1000 ms in a second   10000 ticks in a ms

            if (((ulong)dateTime.Ticks) <= maxticks)
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
