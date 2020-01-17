using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Common;
using NUnitLite;

namespace Exercice1.Tests
{
    public static class Program
    {
        public static int Main( string[] args )
        {
            return new AutoRun( typeof( Program ).Assembly ).Execute( args, new ExtendedTextWrapper(Console.Out), Console.In );
        }
    }
}
