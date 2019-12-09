namespace AdventOfCode.Year2019 {
  using System;
  using System.Collections.Generic;
  using System.Linq;

  using AdventOfCode.Year2019.Utils;

  /// <summary>
  /// Day 3: Crossed Wires
  /// </summary>
  public class Day03 : IDay {
    /// <inheritdoc />
    public void PartOne() {
      var lines = InputFiles.day_03_01.SplitLines().ToArray();
      var solution = Distance(lines[0].Split(','), lines[1].Split(','));
      Console.WriteLine($@"D3P1: {solution}");
    }

    /// <inheritdoc />
    public void PartTwo() {
      var lines = InputFiles.day_03_01.SplitLines().ToArray();
      var solution = NumberOfSteps(lines[0].Split(','), lines[1].Split(','));
      Console.WriteLine($@"D3P2: {solution}");
    }

    /// <summary>
    /// </summary>
    public static int Distance(IEnumerable<string> line1, IEnumerable<string> line2) {
      var crossings = Crossings(line1, line2);
      return crossings.Select(point => Math.Abs(point.X) + Math.Abs(point.Y)).Min();
    }

    /// <summary>
    /// </summary>
    public static int NumberOfSteps(IEnumerable<string> line1, IEnumerable<string> line2) {
      var l1 = DrawPath(line1).ToArray();
      var l2 = DrawPath(line2).ToArray();
      var crossings = l1.Intersect(l2).Skip(1);
      return crossings.Select(point => Array.IndexOf(l1, point) + Array.IndexOf(l2, point)).Min();
    }

    private static IEnumerable<Point> Crossings(IEnumerable<string> line1, IEnumerable<string> line2) {
      return DrawPath(line1).Intersect(DrawPath(line2)).Skip(1);
    }

    private static IEnumerable<Point> DrawPath(IEnumerable<string> steps) {
      var result = new List<Point> { new Point(0, 0) };
      foreach (var step in steps) {
        result.AddRange(DrawLine(step, result.Last()));
      }

      return result;
    }

    private static IEnumerable<Point> DrawLine(string step, Point previous) {
      var result = new List<Point>();
      var direction = step[0] switch {
        'U' => Direction.Up,
        'D' => Direction.Down,
        'L' => Direction.Left,
        'R' => Direction.Right,
        _ => throw new ArgumentException("Incorrect input"),
      };

      var position = previous;
      var numberOfSteps = int.Parse(step.Substring(1));
      for (var i = 0; i < numberOfSteps; i++) {
        position = position.Move(direction);
        result.Add(position);
      }

      return result;
    }
  }

  /// <summary>
  /// </summary>
  public enum Direction {
    /// <summary>
    /// </summary>
    Up,

    /// <summary>
    /// </summary>
    Down,

    /// <summary>
    /// </summary>
    Left,

    /// <summary>
    /// </summary>
    Right
  }

  /// <summary>
  /// </summary>
  public class Point : IEquatable<Point> {
    /// <summary>
    /// </summary>
    public Point(int x, int y) {
      this.X = x;
      this.Y = y;
    }

    /// <summary>
    /// </summary>
    public int X { get; }

    /// <summary>
    /// </summary>
    public int Y { get; }

    /// <inheritdoc />
    public bool Equals(Point other) {
      if (ReferenceEquals(null, other)) {
        return false;
      }

      if (ReferenceEquals(this, other)) {
        return true;
      }

      return this.X == other.X && this.Y == other.Y;
    }

    /// <summary>
    /// </summary>
    public Point Move(Direction direction) {
      return direction switch {
        Direction.Up => new Point(this.X, this.Y + 1),
        Direction.Down => new Point(this.X, this.Y - 1),
        Direction.Left => new Point(this.X - 1, this.Y),
        Direction.Right => new Point(this.X + 1, this.Y),
        _ => throw new ArgumentOutOfRangeException(nameof(direction), direction, null)
      };
    }

    /// <inheritdoc />
    public override bool Equals(object obj) {
      if (ReferenceEquals(null, obj)) {
        return false;
      }

      if (ReferenceEquals(this, obj)) {
        return true;
      }

      return obj.GetType() == this.GetType() && this.Equals((Point)obj);
    }

    /// <inheritdoc />
    public override int GetHashCode() {
      unchecked {
        return (this.X * 397) ^ this.Y;
      }
    }
  }
}
