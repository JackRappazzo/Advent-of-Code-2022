// See https://aka.ms/new-console-template for more information
using Advent1;

Console.WriteLine("Hello, North Pole!");
Console.WriteLine("Loading data...");
ElfStats stats = new ElfStats(Resources.Input);

Console.WriteLine($"The largest stack of calories is {stats.GetHighestCalories()}");
Console.WriteLine($"The calories of the three most burdened elves amounts to {stats.GetHighestCalories(3)}");

Console.WriteLine("Press any key to finish");
Console.ReadKey();
return;