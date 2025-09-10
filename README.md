# WordFinder (.NET + C#)

![.NET](https://img.shields.io/badge/.NET-8-512BD4?logo=dotnet&logoColor=white)
![Language: C#](https://img.shields.io/badge/Language-C%23-239120?logo=csharp&logoColor=white)
![Tests: xUnit](https://img.shields.io/badge/Tests-xUnit-6aa84f)
![.NET CI](https://github.com/mgomez-dev-code/WordFinder/actions/workflows/dotnet.yml/badge.svg)
![License: MIT](https://img.shields.io/badge/License-MIT-green)

A small library + console sample to search a character matrix for the **Top 10 most repeated words** coming from a word stream.  
Matches are scanned **horizontally (left→right)** and **vertically (top→bottom)**.


## Features

- 🔍 Looks up words across **rows** and **columns**.
- 🔟 Returns the **Top 10** words by frequency **in the input stream** that also exist in the matrix (ties resolved alphabetically).
- 🅰️ **Case-sensitive** matching (inputs must match exactly).
- 🧪 Unit tests with **xUnit**.

## Project Structure

    WordFinder.sln
    ├─ WordFinderLib/          # WordFinder class (library)
    │  └─ WordFinder.cs
    ├─ WordFinderApp/          # Optional console app (manual run)
    │  └─ Program.cs
    └─ WordFinder.Tests/       # xUnit tests
       └─ WordFinderTests.cs

## Getting Started

**1) Build & Test (CLI)**

```bash
dotnet build
dotnet test
```

**2) Run the console sample**

```bash
dotnet run --project WordFinderApp
```

## Example

Matrix

    a b c d c
    f g w i o
    c h i l l
    p q n s d
    u v d x y

Word stream

    ["cold", "wind", "snow", "chill"]

Result

    ["chill", "cold", "wind"]

## How it works (brief)

- Precomputes a set with **all substrings** from every row and every column.
- For every word in the input stream, increments its count if it exists in that set.
- Finally sorts by **count desc**, then **word asc**, and takes **Top 10**.

*Complexity (sketch):* building the set is roughly `O(R*C*(R+C))` substrings with hashing; lookups are `O(1)` average per stream item.

## Notes

- **Case-sensitive** search (e.g., `Chill` ≠ `chill`).
- **Duplicates in the stream increase the count** (e.g., if `"wind"` appears twice, it counts twice).
- Returns an empty list if there are no matches.

## License

This project is licensed under the **MIT License**. See `LICENSE` for details.