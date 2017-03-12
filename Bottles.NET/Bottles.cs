using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bottles.NET
{
    public class Bottles
    {
        public static string Verse(int verseNo)
        {
            return @"
99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.
".Trim();
        }
    }
}
