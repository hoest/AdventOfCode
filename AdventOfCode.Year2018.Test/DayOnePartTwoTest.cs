namespace AdventOfCode.Year2018.Test {
  using System;
  using System.Linq;

  using Xunit;

  public class DayOnePartTwoTest {
    [Fact]
    public void Solution() {
      const int Expected = 563;

      var input = Resources.InputD1P1.Split(Environment.NewLine).Select(int.Parse).ToArray();
      var actual = DayOne.FirstDuplicate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test1() {
      const int Expected = 2;

      var input = new[] { +1, -2, +3, +1 };
      var actual = DayOne.FirstDuplicate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test2() {
      const int Expected = 0;

      var input = new[] { +1, -1 };
      var actual = DayOne.FirstDuplicate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test3() {
      const int Expected = 10;

      var input = new[] { +3, +3, +4, -2, -4 };
      var actual = DayOne.FirstDuplicate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test4() {
      const int Expected = 5;

      var input = new[] { -6, +3, +8, +5, -6 };
      var actual = DayOne.FirstDuplicate(input);

      Assert.Equal(Expected, actual);
    }

    [Fact]
    public void Test5() {
      const int Expected = 14;

      var input = new[] { +7, +7, -2, -7, -4 };
      var actual = DayOne.FirstDuplicate(input);

      Assert.Equal(Expected, actual);
    }
  }
}
