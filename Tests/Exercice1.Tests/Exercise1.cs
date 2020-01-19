using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Algos;
using FluentAssertions;
using NUnit.Framework;

namespace Exercice1.Tests
{
    public class Exercise1
    {
        [TestCase( "aaaaaa", true )]//simple tests
        [TestCase( "abcdef", false )]
        [TestCase( "112233", true )]
        [TestCase( "123456", false )]
        [TestCase( "☺☺☻♥♦♣", true )]//a bit more complexs chars
        [TestCase( "☺☻♥♦♣♠", false )]
        [TestCase( "🍾🍾🍾a", true )]
        [TestCase( "🍾🔥❤️", false )]
        [TestCase( "", false )]
        [TestCase( null, false )]
        public void exercise1_works3( string stringToTest, bool haveDuplicate )
        {
            if( stringToTest == null )
            {
                var chars = new char[char.MaxValue];
                for( int i = 0; i < chars.Length; i++ )
                {
                    chars[i] = (char)i;
                }
                stringToTest = chars.ToString();
            }
            for( int i = 0; i < 10_000_000; i++ )//preheat
            {
                stringToTest.ContainsDuplicateChar().Should().Be( haveDuplicate );
            }
            var a = new Stopwatch();
            a.Start();
            for( int i = 0; i < 10_000_000; i++ )
            {
                stringToTest.ContainsDuplicateChar().Should().Be( haveDuplicate );
            }

            Console.Write( "forHashset:"+ a.ElapsedMilliseconds + ";" );
            a.Restart();
            for( int i = 0; i < 10_000_000; i++ )
            {
                stringToTest.ContainsDuplicateCharForeach().Should().Be( haveDuplicate );
            }
            Console.Write( "foreachHashset:"+ a.ElapsedMilliseconds + ";" );

            a.Restart();
            for( int i = 0; i < 10_000_000; i++ )
            {
                stringToTest.ContainsDuplicateCharHashetImpl().Should().Be( haveDuplicate );
            }
            Console.Write("hashsetComparer:"+ a.ElapsedMilliseconds + ";" );

            a.Restart();
            var hashset = new HashSet<char>();
            for( int i = 0; i < 10_000_000; i++ )
            {
                stringToTest.ContainsDuplicateCharForeachHashsetRecycled( hashset ).Should().Be( haveDuplicate );
            }
            Console.Write( a.ElapsedMilliseconds + ";" );
            a.Restart();
            for( int i = 0; i < 10_000_000; i++ )
            {
                stringToTest.ContainsDuplicateCharNoAlloc().Should().Be( haveDuplicate );
            }

            Console.Write( a.ElapsedMilliseconds + ";" );
            a.Restart();
            for( int i = 0; i < 10_000_000; i++ )
            {
                stringToTest.ContainsDuplicateCharNoAllocOpti().Should().Be( haveDuplicate );
            }
            Console.WriteLine( a.ElapsedMilliseconds );
        }
    }
}
