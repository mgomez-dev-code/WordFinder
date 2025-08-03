using System;
using System.Collections.Generic;
using System.Linq;

namespace WordFinderLib
{
    public class WordFinder
    {
        private readonly string[] _matrix;
        private readonly int _rows;
        private readonly int _cols;
        private readonly HashSet<string> _matrixWords = new HashSet<string>();

        public WordFinder(IEnumerable<string> matrix)
        {
            _matrix = matrix.ToArray();
            _rows = _matrix.Length;
            _cols = _matrix[0].Length;

            BuildMatrixWordSet();
        }

        public IEnumerable<string> Find(IEnumerable<string> wordstream)
        {
            var wordCounts = new Dictionary<string, int>();

            foreach (var word in wordstream)
            {
                if (_matrixWords.Contains(word))
                {
                    if (!wordCounts.ContainsKey(word))
                        wordCounts[word] = 0;

                    wordCounts[word]++;
                }
            }

            return wordCounts
                .OrderByDescending(kvp => kvp.Value)
                .ThenBy(kvp => kvp.Key) // optional: alphabetical order in case of tie
                .Take(10)
                .Select(kvp => kvp.Key);
        }

        private void BuildMatrixWordSet()
        {
            // Extract all possible substrings from rows (left to right)
            foreach (var row in _matrix)
            {
                for (int start = 0; start < _cols; start++)
                {
                    for (int len = 1; start + len <= _cols; len++)
                    {
                        _matrixWords.Add(row.Substring(start, len));
                    }
                }
            }

            // Extract all possible substrings from columns (top to bottom)
            for (int col = 0; col < _cols; col++)
            {
                string column = string.Empty;
                for (int row = 0; row < _rows; row++)
                {
                    column += _matrix[row][col];
                }

                for (int start = 0; start < _rows; start++)
                {
                    for (int len = 1; start + len <= _rows; len++)
                    {
                        _matrixWords.Add(column.Substring(start, len));
                    }
                }
            }
        }
    }
}
