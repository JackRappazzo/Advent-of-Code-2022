// See https://aka.ms/new-console-template for more information
using Advent1;

Console.WriteLine("Hello, North Pole!");
Console.WriteLine("Loading data...");
ElfStats stats = new ElfStats(Resources.Input);

Console.WriteLine($"The largest stack of calories is {stats.GetHighestCalorie()}");
Console.WriteLine("Press any key to finish");
Console.ReadKey();
return;