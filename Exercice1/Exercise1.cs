using System;
using System.Collections.Generic;

namespace Algos
{
    public static class Exercise1
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

        public static bool ContainsDuplicateCharForeach( this string theString )
        {
            var chars = new HashSet<char>(); //Because lookup are O(1).
            foreach (char t in theString)
            {
                if( !chars.Add( t ) ) return true;
            }
            return false;
        }

        public static bool ContainsDuplicateCharHashetImpl( this string theString )
        {
            var chars = new HashSet<char>(theString); //Because lookup are O(1).
            return chars.Count != theString.Length;
        }
        public static bool ContainsDuplicateCharForeachHashsetRecycled( this string theString, HashSet<char> chars )
        {
            foreach( char t in theString )
            {
                if( !chars.Add( t ) ) return true;
            }
            return false;
        }

        public static bool ContainsDuplicateCharNoAlloc( this string theString )
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

        public static bool ContainsDuplicateCharNoAllocOpti( this string theString )
        {
            for( int i = 0; i < theString.Length - 1; i++ )
            {
                for( int j = i + 1; j < theString.Length; j++ )
                {
                    if( theString[i] == theString[j] ) return true;
                }
            }
            return false;
        }
    }
}
