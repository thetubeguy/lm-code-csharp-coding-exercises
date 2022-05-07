using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime dateTime)
        {
            double gigaSec = Math.Pow(10, 9);

            DateTime maxdate = DateTime.MaxValue - TimeSpan.FromSeconds(gigaSec);

            return dateTime <= maxdate ? dateTime.AddSeconds(gigaSec) : new DateTime(0001, 1, 1, 0, 0, 0, 0);
        }
    }
}
