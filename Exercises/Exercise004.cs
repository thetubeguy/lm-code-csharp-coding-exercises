using System;
namespace Exercises
{
    public class Exercise004
    {
        public static DateTime AddGigaSecond(DateTime datetime)
        {
            double gigasec = Math.Pow(10,9); 

            DateTime maxdate = DateTime.MaxValue - TimeSpan.FromSeconds(gigasec);

            return datetime <= maxdate ? datetime.AddSeconds(gigasec) : new DateTime(0001, 1, 1, 0, 0, 0, 0);
        }
    }
}
