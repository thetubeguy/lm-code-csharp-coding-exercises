using FluentAssertions;
using NUnit.Framework;
using System;

namespace Exercises.Tests
{
    public class Exercise004Tests
    {
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Only_Date_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 7, 19));
            DateTime expectedResult = new(2053, 3, 27, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_MilliSeconds_Omitted()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(1976, 4, 13, 15, 40, 40));
            DateTime expectedResult = new(2007, 12, 21, 17, 27, 20);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 3, 4, 23, 22, 0, 0));
            DateTime expectedResult = new(2052, 11, 11, 1, 8, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified_With_Day_RollOver()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 1, 24, 23, 59, 59, 0));
            DateTime expectedResult = new(2052, 10, 3, 1, 46, 39);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_MinTime_When_DateTime_Upper_Limit_Exceeded()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(9990, 12, 31, 23, 59, 59, 0));
            DateTime expectedResult = new(0001, 1, 1, 0, 0, 0, 0);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_At_Upper_Limit()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(9968, 04, 23, 22, 13, 19, 999));
            DateTime expectedResult = new(9999, 12, 31, 23, 59, 59, 999);
            actualResult.Should().Be(expectedResult);
        }
    }
}
