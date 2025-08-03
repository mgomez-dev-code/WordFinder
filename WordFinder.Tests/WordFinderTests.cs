using WordFinderLib;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace WordFinder.Tests
{
    public class WordFinderTests
    {
        [Fact]
        public void Find_ShouldReturnCorrectWords_FromMatrix()
        {
            // Arrange
            var matrix = new List<string>
            {
                "abcdc",
                "fgwio",
                "chill",
                "pqnsd",
                "uvdxy"
            };

            var wordsToSearch = new List<string> { "cold", "wind", "snow", "chill" };

            var wordFinder = new WordFinderLib.WordFinder(matrix);

            // Act
            var foundWords = wordFinder.Find(wordsToSearch).ToList();

            // Assert
            Assert.Contains("chill", foundWords);
            Assert.Contains("cold", foundWords);
            Assert.Contains("wind", foundWords);
            Assert.DoesNotContain("snow", foundWords);
        }
    }
}
