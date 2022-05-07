using FluentAssertions;
using NUnit.Framework;
namespace Exercises.Tests
{
    public class Exercise005Tests
    {
        private Exercise005 Exercise005;

        [SetUp]
        public void Setup()
        {
            Exercise005 = new Exercise005();
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Empty_Sentence()
        {
            Exercise005.IsPangram("").Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Perfect_LowerCase_Pangram()
        {
            Exercise005.IsPangram("abcdefghijklmnopqrstuvwxyz").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Perfect_UpperCase_Pangram()
        {
            Exercise005.IsPangram("ABCDEFGHIJKLMNOPQRSTUVWXYZ").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_LowerCase_Pangram()
        {
            Exercise005.IsPangram("the quick brown fox jumps over the lazy dog").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_MixedCase_Pangram()
        {
            Exercise005.IsPangram("The Five boXing wiZards Jump QuicklY").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Missing_LetterX_Sentence()
        {
            Exercise005.IsPangram("the quick brown fo jumps over the lazy dog").Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Missing_LetterH_Sentence()
        {
            Exercise005.IsPangram("five boxing wizards jump quickly at it").Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Pangram_With_Underscores()
        {
            Exercise005.IsPangram("the_quick_brown_fox_jumps_over_the_lazy_dog").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Pangram_With_Numbers()
        {
            Exercise005.IsPangram("the 1 quick brown fox jumps over the 2 lazy dogs").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_Pangram_With_Extra_Letters()
        {
            Exercise005.IsPangram("the quickkkkkkkkkkkk brown fox jumps over the lazy dog").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_False_For_Pangram_With_Extra_Letters_But_Missing_b()
        {
            Exercise005.IsPangram("the quickkkkkkkkkkkk rown fox jumps over the lazy dog").Should().Be(false);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_MixedCase_Pangram_With_Random_Characters()
        {
            Exercise005.IsPangram("The =+Five ///?>boXing wiZ||ards Jum__p Qui!'£$cklY").Should().Be(true);
        }

        [Test]
        public void IsPangram_Should_Return_True_For_MixedCase_Pangram_With_Random_Characters_And_Escaped_Backslash()
        {
            Exercise005.IsPangram("The =+Five ///?>boXing wiZ\\||ards Jum__p Qui!'£$cklY").Should().Be(true);
        }
    }
}
