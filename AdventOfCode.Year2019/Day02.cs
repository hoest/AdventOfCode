namespace AdventOfCode.Year2019 {
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

      var solution = Process(input);
      Console.WriteLine($@"D2P1: {solution[0]}");
    }

    /// <inheritdoc />
    public void PartTwo() {
      for (var noun = 0; noun < 99; noun++) {
        for (var verb = 0; verb < 99; verb++) {
          var input = InputFiles.day_02_01.SplitCsvAsInt();
          input[1] = noun;
          input[2] = verb;

          var solution = Process(input);

          if (solution[0] != 19690720) {
            continue;
          }

          Console.WriteLine($@"D2P2: {noun}{verb}");
          break;
        }
      }
    }

    /// <summary>
    /// Process method
    /// </summary>
    public static int[] Process(int[] input) {
      var codes = new int[input.Length];
      Array.Copy(input, codes, input.Length);
      for (var i = 0; i < codes.Length; i += 4) {
        var opCode = (OpCode)codes[i];
        if (opCode == OpCode.Finished) {
          return codes;
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

      return codes;
    }

    private static string HandleOpcode(IEnumerable<int> take) {
      throw new NotImplementedException();
    }
  }
}
