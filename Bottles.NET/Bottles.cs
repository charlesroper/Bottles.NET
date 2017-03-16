using System;
using System.Collections.Generic;

namespace Bottles.NET
{
    public class Bottles
    {
        public string Verse(int currentVerse)
        {
            int nextVerse = currentVerse - 1;
            var verse = "";
            var br = Environment.NewLine;

            switch (currentVerse)
            {
                case 2:
                    verse = $"{currentVerse} bottles of beer on the wall, {currentVerse} bottles of beer.{br}" +
                            $"Take one down and pass it around, {nextVerse} bottle of beer on the wall.";
                    break;

                case 1:
                    verse = $"{currentVerse} bottle of beer on the wall, {currentVerse} bottle of beer.{br}" +
                             "Take it down and pass it around, no more bottles of beer on the wall.";
                    break;

                case 0:
                    verse = $"No more bottles of beer on the wall, no more bottles of beer.{br}" +
                             "Go to the store and buy some more, 99 bottles of beer on the wall.";
                    break;

                default:
                    verse = $"{currentVerse} bottles of beer on the wall, {currentVerse} bottles of beer.{br}" +
                            $"Take one down and pass it around, {nextVerse} bottles of beer on the wall.";
                    break;
            }
            
            return verse;
        }

        public string Verses(int start=99, int end=0)
        {
            var verses = new List<string>();
            for (int i = start; i >= end; i--)
            {
                verses.Add(Verse(i));
            }
            var br = Environment.NewLine;
            return string.Join(br + br, verses.ToArray());
        }
    }
}
