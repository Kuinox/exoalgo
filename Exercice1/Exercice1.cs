using System;
using System.Collections.Generic;

namespace Algos
{
    public static class Exercice1
    {
        public static bool ContainsDuplicateChar( this string theString )
        {
            var chars = new HashSet<char>(); //Because lookup are O(1).
            for( int i = 0; i < theString.Length; i++ )
            {
                if( !chars.Add( theString[i] ) ) return true;
            }
            return false;
        }

        public static bool ContainsDuplicateCharNoStorage( this string theString )
        {
            for( int i = 0; i < theString.Length; i++ )
            {
                for( int j = 0; j < theString.Length; j++ )
                {
                    if( i == j ) continue;
                    if( theString[i] == theString[j] ) return true;
                }
            }
            return false;
        }
    }
}
