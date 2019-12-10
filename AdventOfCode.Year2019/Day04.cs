namespace AdventOfCode.Year2019 {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using AdventOfCode.Year2019.Utils;

  using JetBrains.Annotations;

  /// <summary>
  /// </summary>
  public class Day04 : IDay {
    /// <inheritdoc />
    public void PartOne() {
      var solution = NumberOfValidPasswords(256310, 732736, ValidateP1);
      Console.WriteLine($@"D4P1: {solution}");
    }

    /// <inheritdoc />
    public void PartTwo() {
      var solution = NumberOfValidPasswords(256310, 732736, ValidateP2);
      Console.WriteLine($@"D4P2: {solution}");
    }

    /// <summary>
    /// </summary>
    public static bool HasCorrectLength([NotNull] IReadOnlyList<int> list) {
      return list.Count == 6;
    }

    /// <summary>
    /// </summary>
    public static bool IsIncreasing([NotNull] IReadOnlyList<int> list) {
      return !list.Where((t, i) => i + 1 < list.Count && t > list[i + 1]).Any();
    }

    /// <summary>
    /// </summary>
    public static bool HasAdjacentDigits([NotNull] IReadOnlyList<int> list) {
      return list.Where((t, i) => i + 1 < list.Count && t == list[i + 1]).Any();
    }

    /// <summary>
    /// </summary>
    public static bool HasDoubleAdjacentDigits([NotNull] IReadOnlyList<int> list) {
      return list.GroupBy(i => i).Any(grouping => grouping.Count() == 2);
    }

    /// <summary>
    /// </summary>
    private static int NumberOfValidPasswords(int from, int to, Func<int, bool> validateFunc) {
      var list = new List<int>();
      if (from >= to) {
        return 0;
      }

      for (var i = from; i <= to; i++) {
        if (validateFunc(i)) {
          list.Add(i);
        }
      }

      return list.Count;
    }

    /// <summary>
    /// </summary>
    private static bool ValidateP1(int input) {
      var list = input.AsReadOnlyList();
      return HasCorrectLength(list) && IsIncreasing(list) && HasAdjacentDigits(list);
    }

    /// <summary>
    /// </summary>
    private static bool ValidateP2(int input) {
      var list = input.AsReadOnlyList();
      return HasCorrectLength(list) && IsIncreasing(list) && HasAdjacentDigits(list) && HasDoubleAdjacentDigits(list);
    }
  }
}
