using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bottles.NET
{
    public class Bottles
    {
        public string Verse(int currentVerse)
        {
            int nextVerse = currentVerse - 1;
            var lineOne = string.Empty;
            var lineTwo = string.Empty;

            if (currentVerse > 2)
            {
                lineOne = $"{currentVerse} bottles of beer on the wall, {currentVerse} bottles of beer.{Environment.NewLine}";
                lineTwo = $"Take one down and pass it around, {nextVerse} bottles of beer on the wall.";

            }

            if (currentVerse == 2)
            {
                lineOne = $"{currentVerse} bottles of beer on the wall, {currentVerse} bottles of beer.{Environment.NewLine}";
                lineTwo = $"Take one down and pass it around, {nextVerse} bottle of beer on the wall.";
            }

            if (currentVerse == 1)
            {
                lineOne = $"{currentVerse} bottle of beer on the wall, {currentVerse} bottle of beer.{Environment.NewLine}";
                lineTwo = $"Take it down and pass it around, no more bottles of beer on the wall.";
            }

            if (currentVerse == 0)
            {
                lineOne = $"No more bottles of beer on the wall, no more bottles of beer.{Environment.NewLine}";
                lineTwo = "Go to the store and buy some more, 99 bottles of beer on the wall.";
            }
            
            var verse = lineOne + lineTwo;

            return verse;
        }

        public string Verses(int start, int end)
        {
            return null;
        }
    }
}
