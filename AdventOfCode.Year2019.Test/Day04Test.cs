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
      Assert.Equal(expected, Day04.IsIncreasing(input));
    }

    [Theory]
    [InlineData(122345, true)]
    [InlineData(111111, true)]
    [InlineData(111123, true)]
    [InlineData(135679, false)]
    [InlineData(223450, true)]
    public void HasAdjacentDigits_Test(int input, bool expected) {
      Assert.Equal(expected, Day04.HasAdjacentDigits(input));
    }

    [Theory]
    [InlineData(1234, false)]
    [InlineData(123456, true)]
    public void HasCorrectLength_Test(int input, bool expected) {
      Assert.Equal(expected, Day04.HasCorrectLength(input));
    }

    [Theory]
    [InlineData(0, 0, 0)]
    [InlineData(111_111, 111_112, 2)]
    public void NumberOfValidPasswords_Test(int from, int to, int numberOfPasswords) {
      Assert.Equal(numberOfPasswords, Day04.NumberOfValidPasswords(from, to));
    }
  }
}
