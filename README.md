# WordFinder Challenge

## Overview

This solution implements the `WordFinder` class as described in the technical challenge. It efficiently searches a character matrix for the top 10 most repeated words from a given word stream, searching horizontally (left to right) and vertically (top to bottom).

## Features

- Accepts a matrix up to 64x64 in size.
- Searches both rows and columns for valid words.
- Efficiently returns the 10 most repeated words found in the matrix.
- Includes unit tests with `xUnit`.

## Project Structure

- `WordFinderLib`: Class library containing the `WordFinder` logic.
- `WordFinderApp`: Optional console app for manual testing.
- `WordFinder.Tests`: xUnit test project with unit tests.

## How to Run

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Set `WordFinderApp` as the startup project if you'd like to run the console example.
4. Run tests using Test Explorer (`Test -> Run All Tests`) or via CLI.

## Example Matrix

```plaintext
a b c d c
f g w i o
c h i l l
p q n s d
u v d x y
```

Example wordstream: `["cold", "wind", "snow", "chill"]`  
Result: `["chill", "cold", "wind"]`

## Notes

- Words must appear exactly as provided (case-sensitive).
- Duplicates in the input stream are only counted once.
- If no matches are found, the result is an empty list.

---

© Mauricio G.
