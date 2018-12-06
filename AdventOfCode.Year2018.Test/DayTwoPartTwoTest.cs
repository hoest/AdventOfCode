namespace AdventOfCode.Year2018.Test {
  using System.IO;
  using System.Linq;

  using Xunit;

  public class DayTwoPartTwoTest {
    [Fact]
    public void Solution() {
      const string Expected = "ivjhcadokeltwgsfsmqwrbnuy";

      var input = File.ReadAllLines(
          "/Users/jelle/Development/Hoest/AdventOfCode/AdventOfCode.Year2018.Test/Resources/InputD2P1.txt")
        .ToArray();
      var actual = DayTwo.CommonLetters(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test1() {
      var input = new[] { "abcde", "fghij", "klmno", "pqrst", "fguij", "axcye", "wvxyz" };

      const string Expected = "fgij";
      var actual = DayTwo.CommonLetters(input);
      Assert.Equal(Expected, actual);
    }
  }
}
