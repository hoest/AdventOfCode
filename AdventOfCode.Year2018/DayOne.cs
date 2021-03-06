﻿namespace AdventOfCode.Year2018 {
  using System.Collections.Generic;
  using System.Linq;

  public class DayOne {
    /// <summary>
    /// Day 1 - Part 1
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static int Calibrate(IEnumerable<int> numbers) {
      return numbers.Sum();
    }

    /// <summary>
    /// Day 1 - Part 2
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    public static int FirstDuplicate(IEnumerable<int> numbers) {
      var numbersArr = numbers.ToArray();
      var currentFrequency = 0;
      var reached = new List<int> { 0 };

      while (true) {
        foreach (var change in numbersArr) {
          var result = currentFrequency + change;
          if (reached.Contains(result)) {
            return result;
          }

          reached.Add(result);
          currentFrequency = result;
        }
      }
    }
  }
}
