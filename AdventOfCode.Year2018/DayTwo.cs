namespace AdventOfCode.Year2018 {
  using System.Collections.Generic;
  using System.Linq;

  public class DayTwo {
    public static int Checksum(IEnumerable<string> input) {
      var appearsTwice = Appearance(input, 2);
      var appearsThreeTimes = Appearance(input, 3);

      return appearsTwice * appearsThreeTimes;
    }

    private static int Appearance(IEnumerable<string> input, int number) {
      return input
        .Select(id => id.ToCharArray().GroupBy(c => c).Select(c => (character: c.Key, count: c.Count())).ToArray())
        .Aggregate(0, (current, tuples) => current + (tuples.Any(c => c.count == number) ? 1 : 0));
    }
  }
}
