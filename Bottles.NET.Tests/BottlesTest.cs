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
Take one down and pass it around, 98 bottles of beer on the wall.
".Trim();

            _output.WriteLine("Verse 99: {0}", sut);
            _output.WriteLine("Expected: {0}", expected);

            Assert.Equal(expected, sut);
        }
    }
}
