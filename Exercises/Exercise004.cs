using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime datetime)
        {
            double gigasec = Math.Pow(10,9); 

            DateTime maxdate = DateTime.MaxValue - TimeSpan.FromSeconds(gigasec);

            if (datetime <= maxdate)
                return (datetime.AddSeconds(gigasec));
            else
                return (new DateTime(0001, 1, 1, 0, 0, 0, 0));
        }
    }
}
