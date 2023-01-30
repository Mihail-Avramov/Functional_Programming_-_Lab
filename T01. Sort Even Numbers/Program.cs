using System;
using System.Linq;

int[] numbers = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Action<int[]> printEvenNumbers = numbers =>
    Console.WriteLine(string.Join(", ", numbers.Where(n => n % 2 == 0).OrderBy(n => n)));


printEvenNumbers(numbers);