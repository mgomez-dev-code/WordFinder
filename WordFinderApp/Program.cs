using WordFinderLib;

var matrix = new List<string>
{
    "abcdc",
    "fgwio",
    "chill",
    "pqnsd",
    "uvdxy"
};

var wordStream = new List<string> { "cold", "wind", "snow", "chill" };

var finder = new WordFinder(matrix);
var foundWords = finder.Find(wordStream);

Console.WriteLine("Words found:");
foreach (var word in foundWords)
{
    Console.WriteLine(word);
}

