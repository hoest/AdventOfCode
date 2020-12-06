namespace AdventOfCode.Year2020 {
  using System;
  using System.Linq;
  using System.Reflection;

  internal static class Program {
    private static void Main(string[] args) {
      var instances = Assembly.GetExecutingAssembly()
        .GetTypes()
        .Where(type => typeof(IDay).IsAssignableFrom(type))
        .Where(type => !type.IsAbstract && !type.IsGenericType && type.GetConstructor(Array.Empty<Type>()) != null)
        .OrderBy(type => type.FullName)
        .Select(type => (IDay)Activator.CreateInstance(type))
        .ToList();

      foreach (var instance in instances) {
        instance.PartOne();
        instance.PartTwo();
      }
    }
  }
}
