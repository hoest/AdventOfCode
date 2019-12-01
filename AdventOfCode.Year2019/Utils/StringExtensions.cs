namespace AdventOfCode.Year2019.Utils {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public static class StringExtensions {
    public static IEnumerable<int> SplitLinesAsInt(this string s) {
      return s.Split(new[] { Environment.NewLine, "\n" }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
    }
  }
}
