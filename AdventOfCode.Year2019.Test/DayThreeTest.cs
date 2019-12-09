namespace AdventOfCode.Year2019.Test {
  using Xunit;

  public class DayThreeTest {
    [Theory]
    [InlineData(new[] { "R8", "U5", "L5", "D3" }, new[] { "U7", "R6", "D4", "L4" }, 6)]
    [InlineData(
      new[] { "R75", "D30", "R83", "U83", "L12", "D49", "R71", "U7", "L72" },
      new[] { "U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83" },
      159)]
    [InlineData(
      new[] { "R98", "U47", "R26", "D63", "R33", "U87", "L62", "D20", "R33", "U53", "R51" },
      new[] { "U98", "R91", "D20", "R16", "D67", "R40", "U7", "R15", "U6", "R7" },
      135)]
    public void DrawLine_Test(string[] line1, string[] line2, int expected) {
      // Act
      var actual = Day03.Distance(line1, line2);

      // Assert
      Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(new[] { "R8", "U5", "L5", "D3" }, new[] { "U7", "R6", "D4", "L4" }, 30)]
    [InlineData(
      new[] { "R75", "D30", "R83", "U83", "L12", "D49", "R71", "U7", "L72" },
      new[] { "U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83" },
      610)]
    [InlineData(
      new[] { "R98", "U47", "R26", "D63", "R33", "U87", "L62", "D20", "R33", "U53", "R51" },
      new[] { "U98", "R91", "D20", "R16", "D67", "R40", "U7", "R15", "U6", "R7" },
      410)]
    public void NumberOfSteps_Test(string[] line1, string[] line2, int expected) {
      // Act
      var actual = Day03.NumberOfSteps(line1, line2);

      // Assert
      Assert.Equal(expected, actual);
    }
  }
}
