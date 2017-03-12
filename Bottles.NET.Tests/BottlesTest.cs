using Xunit;
using Xunit.Abstractions;

namespace Bottles.NET.Tests
{
    public class BottlesTest
    {
        private readonly ITestOutputHelper _output;

        public BottlesTest(ITestOutputHelper output)
        {
            this._output = output;
        }

        [Fact]
        public void TestTheFirstVerse()
        {
            var sut = Bottles.Verse(99);

            var expected = @"
99 bottles of beer on the wall, 99 bottles of beer.
Take one down and pass it around, 98 bottles of beer on the wall.".Trim();

            Assert.Equal(expected, sut);
        }

        [Fact]
        public void TestAnotherVerse()
        {
            var sut = Bottles.Verse(89);

            var expected = @"
89 bottles of beer on the wall, 89 bottles of beer.
Take one down and pass it around, 88 bottles of beer on the wall.".Trim();

            Assert.Equal(expected, sut);
        }
    }
}
