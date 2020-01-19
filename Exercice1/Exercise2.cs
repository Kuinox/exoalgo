using System;
using System.Collections.Generic;
using System.Linq;
namespace Algos
{
    public static class Exercise2
    {
        public static bool IsStringPermutationOf( this string stringA, string stringB )
        {
            if( stringA.Length != stringB.Length ) return false;
            var charCounts = new Dictionary<char, int>();
            for( int i = 0; i < stringA.Length; i++ )
            {
                char a = stringA[i];
                if( !charCounts.TryGetValue( a, out int valA ) )
                {
                    charCounts[a] = 1;
                }
                else
                {
                    charCounts[a] = valA + 1;
                }
                char b = stringB[i];
                if( !charCounts.TryGetValue( b, out int valB ) )
                {
                    charCounts[b] = -1;
                }
                else
                {
                    charCounts[b] = valB - 1;
                }
            }
            return charCounts.All( s => s.Value == 0 );
        }
    }
}
