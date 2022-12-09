// See https://aka.ms/new-console-template for more information
using Advent4;
using Advent4.IO;

Console.WriteLine("Hello, Campers!");

Console.WriteLine("Reading camp order sheet...");
List<Pair> pairs = CampParser.Parse(Resource.Input);

Console.WriteLine($"There are {pairs.Where(p => p.IsRedundant()).Count()} pairs with redundant orders!");
Console.WriteLine($"There are {pairs.Where(p => p.IsOverlapping()).Count()} pairs with overlapping orders!");
Console.WriteLine("Press any key to finish");
Console.ReadKey();






