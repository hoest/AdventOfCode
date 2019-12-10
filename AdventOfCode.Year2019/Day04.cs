namespace AdventOfCode.Year2019 {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using AdventOfCode.Year2019.Utils;

  /// <summary>
  /// </summary>
  public class Day04 : IDay {
    /// <inheritdoc />
    public void PartOne() {
      var solution = NumberOfValidPasswords(256310, 732736);
      Console.WriteLine($@"D4P1: {solution}");
    }

    /// <inheritdoc />
    public void PartTwo() {
      var solution = "?";
      Console.WriteLine($@"D4P2: {solution}");
    }

    /// <summary>
    /// </summary>
    public static int NumberOfValidPasswords(int from, int to) {
      var list = new List<int>();
      for (var i = from; i <= to; i++) {
        if (HasCorrectLength(i) && IsIncreasing(i) && HasAdjacentDigits(i)) {
          list.Add(i);
        }
      }

      return list.Count;
    }

    /// <summary>
    /// </summary>
    public static bool HasCorrectLength(int input) {
      var list = input.AsReadOnlyList();
      return list.Count == 6;
    }

    /// <summary>
    /// </summary>
    public static bool IsIncreasing(int input) {
      var list = input.AsReadOnlyList();
      return !list.Where((t, i) => i + 1 < list.Count && t > list[i + 1]).Any();
    }

    /// <summary>
    /// </summary>
    public static bool HasAdjacentDigits(int input) {
      var list = input.AsReadOnlyList();
      return list.Where((t, i) => i + 1 < list.Count && t == list[i + 1]).Any();
    }
  }
}
