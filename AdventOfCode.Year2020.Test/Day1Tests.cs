namespace AdventOfCode.Year2020.Test {
  using Xunit;

  public class Day1Tests {
    [Fact]
    public void PartOne() {
      var input = new[] { 1721, 979, 366, 299, 675, 1456 };
      var day1 = new Day1();
      var (one, two) = day1.FindSumTo2020(input);

      Assert.Equal(1721, one);
      Assert.Equal(299, two);
      Assert.Equal(514579, one * two);
    }

    [Fact]
    public void PartTwo() {
      var input = new[] { 1721, 979, 366, 299, 675, 1456 };
      var day1 = new Day1();
      var (one, two, three) = day1.FindSumOfThreeTo2020(input);

      Assert.Equal(979, one);
      Assert.Equal(366, two);
      Assert.Equal(675, three);
      Assert.Equal(241861950, one * two * three);
    }
  }
}
