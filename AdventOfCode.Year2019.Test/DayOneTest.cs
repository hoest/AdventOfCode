namespace AdventOfCode.Year2019.Test {
  using Xunit;

  public class DayOneTest {
    [Fact]
    public void FuelRequired_Test() {
      Assert.Equal(2, Day01.FuelRequired(12));
      Assert.Equal(2, Day01.FuelRequired(14));
      Assert.Equal(654, Day01.FuelRequired(1969));
      Assert.Equal(33583, Day01.FuelRequired(100756));
    }

    [Fact]
    public void FuelWithFuel_Test() {
      Assert.Equal(2, Day01.FuelWithFuel(12));
      Assert.Equal(2, Day01.FuelWithFuel(14));
      Assert.Equal(966, Day01.FuelWithFuel(1969));
      Assert.Equal(50346, Day01.FuelWithFuel(100756));
    }
  }
}
