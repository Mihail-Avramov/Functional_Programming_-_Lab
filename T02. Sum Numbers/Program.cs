using System;
using System.Linq;

int[] numbers = Console.ReadLine()
    .Split(", ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Action<int[]> countNumbers = n => Console.WriteLine(n.Count());

Action<int[]> sumNumbers = n => Console.WriteLine(n.Sum());

countNumbers(numbers);
sumNumbers(numbers);