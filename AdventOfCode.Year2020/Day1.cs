namespace AdventOfCode.Year2020 {
  using System;
  using System.Collections.Generic;
  using System.Collections.ObjectModel;
  using System.Linq;

  /// <summary>
  /// Day1 class
  /// </summary>
  public class Day1 : IDay {
    private readonly ReadOnlyCollection<int> input;

    /// <summary>
    /// Constructor
    /// </summary>
    public Day1() {
      this.input = InputFiles.d1p1.Trim()
        .Split(Environment.NewLine)
        .Select(s => s.Trim())
        .Select(int.Parse)
        .ToList()
        .AsReadOnly();
    }

    /// <inheritdoc />
    public void PartOne() {
      var (one, two) = this.FindSumTo2020(this.input);
      Console.WriteLine($@"D1P1 : {one} * {two} = {one * two}");
    }

    /// <inheritdoc />
    public void PartTwo() {
      var (one, two, three) = this.FindSumOfThreeTo2020(this.input);
      Console.WriteLine($@"D1P2 : {one} * {two} * {three} = {one * two * three}");
    }

    /// <summary>
    /// Specifically, they need you to find the two entries that sum
    /// to 2020 and then multiply those two numbers together.
    /// </summary>
    public (int one, int two) FindSumTo2020(IReadOnlyList<int> input) {
      return (from one in input let two = 2020 - one where input.Contains(two) select (one, two)).First();
    }

    /// <summary>
    /// In your expense report, what is the product of the three entries that sum to 2020?
    /// </summary>
    public (int one, int two, int three) FindSumOfThreeTo2020(IReadOnlyList<int> input) {
      return (from one in input
              from two in input
              let three = 2020 - one - two
              where input.Contains(three)
              select (one, two, three)).First();
    }
  }
}
