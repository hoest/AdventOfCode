namespace AdventOfCode.Year2019.Utils {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  /// <summary>
  /// </summary>
  public static class IntegerExtensions {
    /// <summary>
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static IReadOnlyList<int> AsReadOnlyList(this int input) {
      var digits = new int[1 + (int)Math.Log10(input)];
      for (var i = digits.Length - 1; i >= 0; i--) {
        input = Math.DivRem(input, 10, out var digit);
        digits[i] = digit;
      }

      return digits.ToList().AsReadOnly();
    }
  }
}
