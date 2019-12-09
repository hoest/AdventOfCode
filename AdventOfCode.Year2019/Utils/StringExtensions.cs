namespace AdventOfCode.Year2019.Utils {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  /// <summary>
  /// String extension methods
  /// </summary>
  public static class StringExtensions {
    /// <summary>
    /// Split a string in lines
    /// </summary>
    public static IEnumerable<string> SplitLines(this string s) {
      return s.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries);
    }

    /// <summary>
    /// Split a string in lines and convert to integers
    /// </summary>
    public static IEnumerable<int> SplitLinesAsInt(this string s) {
      return s.SplitLines().Select(int.Parse);
    }

    /// <summary>
    /// Split a CSV string with ',' and convert to int[]
    /// </summary>
    public static int[] SplitCsvAsInt(this string s) {
      return s.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    }
  }
}
