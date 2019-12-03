﻿namespace AdventOfCode.Year2019 {
  using System;
  using System.Collections.Generic;

  using AdventOfCode.Year2019.Utils;

  using JetBrains.Annotations;

  internal enum OpCode {
    Add = 1,
    Multiply = 2,
    Finished = 99
  }

  /// <summary>
  /// Day 2 - 2019
  /// </summary>
  [UsedImplicitly]
  public class Day02 : IDay {
    /// <inheritdoc />
    public void PartOne() {
      var input = InputFiles.day_02_01.SplitCsvAsInt();
      input[1] = 12;
      input[2] = 2;

      var solution = Process(string.Join(",", input));
      Console.WriteLine($@"D2P1: {solution}");
    }

    /// <inheritdoc />
    public void PartTwo() {
      throw new NotImplementedException();
    }

    /// <summary>
    /// Process method
    /// </summary>
    public static string Process(string codeString) {
      var codes = codeString.SplitCsvAsInt();
      for (var i = 0; i < codes.Length; i += 4) {
        var opCode = (OpCode)codes[i];
        if (opCode == OpCode.Finished) {
          return string.Join(",", codes);
        }

        var pos1 = codes[i + 1];
        var pos2 = codes[i + 2];
        var pos3 = codes[i + 3];

        codes[pos3] = opCode switch {
          OpCode.Add => (codes[pos1] + codes[pos2]),
          OpCode.Multiply => (codes[pos1] * codes[pos2]),
          _ => codes[pos3]
        };
      }

      return string.Join(",", codes);
    }

    private static string HandleOpcode(IEnumerable<int> take) {
      throw new NotImplementedException();
    }
  }
}
