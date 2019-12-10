namespace AdventOfCode.Year2019.Test {
  using AdventOfCode.Year2019.Utils;

  using Xunit;

  public class Day04Test {
    [Theory]
    [InlineData(123456, new[] { 1, 2, 3, 4, 5, 6 })]
    [InlineData(654321, new[] { 6, 5, 4, 3, 2, 1 })]
    [InlineData(987632, new[] { 9, 8, 7, 6, 3, 2 })]
    public void IntegerAsReadOnlyList_Test(int input, int[] expected) {
      Assert.Equal(expected, input.AsReadOnlyList());
    }

    [Theory]
    [InlineData(122345, true)]
    [InlineData(111111, true)]
    [InlineData(111123, true)]
    [InlineData(135679, true)]
    [InlineData(223450, false)]
    public void IsIncreasing_Test(int input, bool expected) {
      Assert.Equal(expected, Day04.IsIncreasing(input.AsReadOnlyList()));
    }

    [Theory]
    [InlineData(122345, true)]
    [InlineData(111111, true)]
    [InlineData(111123, true)]
    [InlineData(135679, false)]
    [InlineData(223450, true)]
    public void HasAdjacentDigits_Test(int input, bool expected) {
      Assert.Equal(expected, Day04.HasAdjacentDigits(input.AsReadOnlyList()));
    }

    [Theory]
    [InlineData(112233, true)]
    [InlineData(123444, false)]
    [InlineData(111122, true)]
    public void HasDoubleAdjacentDigits_Test(int input, bool expected) {
      Assert.Equal(expected, Day04.HasDoubleAdjacentDigits(input.AsReadOnlyList()));
    }

    [Theory]
    [InlineData(1234, false)]
    [InlineData(123456, true)]
    public void HasCorrectLength_Test(int input, bool expected) {
      Assert.Equal(expected, Day04.HasCorrectLength(input.AsReadOnlyList()));
    }
  }
}
