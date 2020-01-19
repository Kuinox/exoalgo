using System.Linq;
using Algos;
using FluentAssertions;
using NUnit.Framework;

namespace Exercice1.Tests
{
    public class Exercise2
    {
        [TestCase("abcabc", "aabbcc", true )]
        [TestCase("abcabc", "aabccc", false )]
        [TestCase("Hello World", "orldW olleH", true )]
        [TestCase("☺☺☻☻♥♥", "☺☻♥☺☻♥", true )]
        [TestCase("☺☺☻☻♥♥", "☺☻♥☺♥", false )]
        [TestCase( "🔥💫🇯🇵🔥💫🇯🇵", "🔥🔥💫💫🇯🇵🇯🇵", true )]
        [TestCase( "🔥💫🇯🇵🔥💫🇯🇵", "🔥💫🇯🇵😂", false )]
        [TestCase( "", "", true )]
        [TestCase( "a", "", false )]
        [TestCase( "", "a", false )]
        public void exercise2_works( string stringA, string stringB, bool isPermutation)
        {
            stringA.IsStringPermutationOf( stringB ).Should().Be( isPermutation );
        }
    }
}
