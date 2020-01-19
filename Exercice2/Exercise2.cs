using System;
using System.Collections.Generic;
using System.Linq;
namespace Exercice2
{
    public static class Exercice2
    {
        public static bool IsStringPermutationOf( this string stringA, string stringB )
        {
            if( stringA.Length != stringB.Length ) return false;
            var charCountsA = new Dictionary<char, int>();
            var charCountsB = new Dictionary<char, int>();
            for( int i = 0; i < stringA.Length; i++ )
            {
                charCountsA[stringA[i]]++;
                charCountsB[stringB[i]]++;
            }

            foreach( KeyValuePair<char, int> kvp in charCountsA )
            {
                if( !charCountsB.TryGetValue( kvp.Key, out int val ) ) return false;
                if( val != kvp.Value ) return false;
            }
            return true;
        }
    }
}
