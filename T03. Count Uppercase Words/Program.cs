using System;

string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Func<string, bool> isUppercaseLetter = s => char.IsUpper(s[0]);

foreach (var word in words)
{
    if (isUppercaseLetter(word))
    {
        Console.WriteLine(word);
    }
}