namespace AdventOfCode.Year2019.Test {
  using Xunit;

  public class Day02Test {
    [Fact]
    public void Process_Test() {
      Assert.Equal(new[] { 2, 0, 0, 0, 99 }, Day02.Process(new[] { 1, 0, 0, 0, 99 }));
      Assert.Equal(new[] { 2, 3, 0, 6, 99 }, Day02.Process(new[] { 2, 3, 0, 3, 99 }));
      Assert.Equal(new[] { 2, 4, 4, 5, 99, 9801 }, Day02.Process(new[] { 2, 4, 4, 5, 99, 0 }));
      Assert.Equal(new[] { 30, 1, 1, 4, 2, 5, 6, 0, 99 }, Day02.Process(new[] { 1, 1, 1, 4, 99, 5, 6, 0, 99 }));
    }
  }
}
