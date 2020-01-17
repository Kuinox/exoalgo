using System.Linq;
using Algos;
using FluentAssertions;
using NUnit.Framework;

namespace Exercice1.Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase("aaaaaa", true)]//simple tests
        [TestCase("abcdef", false)]
        [TestCase("112233", true)]
        [TestCase("123456", false)]
        [TestCase("☺☺☻♥♦♣", true)]//a bit more complexs chars
        [TestCase("☺☻♥♦♣♠", false)]
        [TestCase("🍾🍾🍾a", true)]
        [TestCase("🍾🔥❤️", false)]
        [TestCase(null, false)]
        public void exercice1_works(string stringToTest, bool haveDuplicate)
        {
            if( stringToTest == null)
            {
                var chars = new char[char.MaxValue];
                for( int i = 0; i < chars.Length; i++ )
                {
                    chars[i] = (char) i;
                }
                stringToTest = chars.ToString();
            }

            stringToTest.ContainsDuplicateChar().Should().Be( haveDuplicate );
            stringToTest.ContainsDuplicateCharNoStorage().Should().Be( haveDuplicate );
        }
    }
}
