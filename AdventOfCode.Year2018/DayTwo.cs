namespace AdventOfCode.Year2018 {
  using System.Collections.Generic;
  using System.Linq;

  public class DayTwo {
    public static int Checksum(IEnumerable<string> input) {
      var inputArr = input as string[] ?? input.ToArray();
      var appearsTwice = Appearance(inputArr, 2);
      var appearsThreeTimes = Appearance(inputArr, 3);

      return appearsTwice * appearsThreeTimes;
    }

    public static string CommonLetters(IEnumerable<string> input) {
      var inputArr = input.ToArray();

      string firstPair = null;
      for (var i = 0; i < inputArr[0].Length; i++) {
        var pair = inputArr.Select(id => id.Remove(i, 1)).GroupBy(id => id).FirstOrDefault(g => g.Count() > 1);
        if (pair == null) {
          continue;
        }

        firstPair = pair.First();
        break;
      }

      return firstPair;
    }

    private static int Appearance(IEnumerable<string> input, int number) {
      return input
        .Select(id => id.ToCharArray().GroupBy(c => c).Select(c => (character: c.Key, count: c.Count())).ToArray())
        .Aggregate(0, (current, tuples) => current + (tuples.Any(c => c.count == number) ? 1 : 0));
    }
  }
}
