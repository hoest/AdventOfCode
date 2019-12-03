namespace AdventOfCode.Year2019 {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using AdventOfCode.Year2019.Utils;

  using JetBrains.Annotations;

  /// <summary>
  /// Day 1 - 2019
  /// </summary>
  [UsedImplicitly]
  public class Day01 : IDay {
    /// <inheritdoc />
    public void PartOne() {
      var solution = InputFiles.day_01_01.SplitLinesAsInt().Select(FuelRequired).Sum();
      Console.WriteLine($@"D1P1: {solution:F0}");
    }

    /// <inheritdoc />
    public void PartTwo() {
      var solution = InputFiles.day_01_01.SplitLinesAsInt().Select(FuelWithFuel).Sum();
      Console.WriteLine($@"D1P2: {solution:F0}");
    }

    /// <summary>
    /// Method to calculate the sum of the fuel requirements for all of the modules on your spacecraft
    /// </summary>
    public static int FuelWithFuel(int mass) {
      int Result(int m) {
        var f = FuelRequired(m);
        return f > 0 ? f : 0;
      }

      IEnumerable<int> Loop(int m) {
        var f = m;
        while ((f = Result(f)) > 0) {
          yield return f;
        }
      }

      return Loop(mass).Sum();
    }

    /// <summary>
    /// Method to calculate the sthe fuel requirements
    /// </summary>
    public static int FuelRequired(int mass) {
      return Convert.ToInt32(Math.Floor(mass / 3.0) - 2);
    }
  }
}
