namespace AdventOfCode.Year2018.Test {
  using System.IO;
  using System.Linq;

  using Xunit;

  public class DayOnePartOneTest {
    [Fact]
    public void Solution() {
      const int Expected = 561;

      var input = File.ReadAllLines(
          "/Users/jelle/Development/Hoest/AdventOfCode/AdventOfCode.Year2018.Test/Resources/InputD1P1.txt")
        .Select(int.Parse)
        .ToArray();
      var actual = DayOne.Calibrate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test1() {
      const int Expected = 3;

      var input = new[] { +1, -2, +3, +1 };
      var actual = DayOne.Calibrate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test2() {
      const int Expected = 3;

      var input = new[] { +1, +1, +1 };
      var actual = DayOne.Calibrate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test3() {
      const int Expected = 0;

      var input = new[] { +1, +1, -2 };
      var actual = DayOne.Calibrate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test4() {
      const int Expected = -6;

      var input = new[] { -1, -2, -3 };
      var actual = DayOne.Calibrate(input);

      Assert.Equal(Expected, actual);
    }
  }
}
