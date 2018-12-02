namespace AdventOfCode.Year2018.Test {
  using System.IO;
  using System.Linq;

  using Xunit;

  public class DayTwoPartOneTest {
    [Fact]
    public void Solution() {
      const int Expected = 7657;

      var input = File.ReadAllLines(
          "/Users/jelle/Development/Hoest/AdventOfCode/AdventOfCode.Year2018.Test/Resources/InputD2P1.txt")
        .ToArray();
      var actual = DayTwo.Checksum(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test1() {
      var input = new[] {
        "abcdef",
        "bababc",
        "abbcde",
        "abcccd",
        "aabcdd",
        "abcdee",
        "ababab"
      };

      const int Expected = 12;
      var actual = DayTwo.Checksum(input);
      Assert.Equal(Expected, actual);
    }
  }
}
