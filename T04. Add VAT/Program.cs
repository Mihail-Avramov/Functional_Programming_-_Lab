using System;
using System.Linq;

double[] pricesWithoutVAT = Console.ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(double.Parse)
    .ToArray();


Func<double[], double[]> addVAT = prices => prices.Select(price => price * 1.2).ToArray();

Action<double[]> printPrices = prices =>
{
    foreach (var price in prices)
    {
        Console.WriteLine($"{price:f2}");
    }
};

double[] pricesWithVAT = addVAT(pricesWithoutVAT);

printPrices(pricesWithVAT);