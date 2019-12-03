namespace AdventOfCode.Year2019.Utils {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  /// <summary>
  /// String extension methods
  /// </summary>
  public static class StringExtensions {
    /// <summary>
    /// Split a string in lines and convert to integers
    /// </summary>
    public static IEnumerable<int> SplitLinesAsInt(this string s) {
      return s.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
    }
  }
}
