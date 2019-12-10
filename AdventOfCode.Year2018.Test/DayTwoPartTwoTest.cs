namespace AdventOfCode.Year2018.Test {
  using System;
  using System.Linq;

  using Xunit;

  public class DayTwoPartTwoTest {
    [Fact]
    public void Solution() {
      const string Expected = "ivjhcadokeltwgsfsmqwrbnuy";

      var input = Resources.InputD2P1.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToArray();
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
