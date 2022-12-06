// See https://aka.ms/new-console-template for more information
using Advent3;
using Advent3.IO;
using Advent3.Resources;

Console.WriteLine("Hello packing elves!");

Console.WriteLine("Reading inventory...");
List<Rucksack> rucks = RuckParser.Parse(Resource.Input);

Console.WriteLine($"Inventory of {rucks.Count} rucks has been loaded");

int total = rucks.Sum(r => r.GetMisconfiguredPriority());

Console.WriteLine($"Misconfigured items with a total priority of {total} have been found");


Console.WriteLine($"Assigning groups...");

List<ElfGroup> groups = new List<ElfGroup>();
for (int i = 0; i < rucks.Count; i += 3)
{
    groups.Add(new ElfGroup(rucks.Skip(i).Take(3).ToList()));
}

Console.WriteLine($"Assigned {groups.Count} groups, with a combined badge priority of {groups.Sum(g=>g.BadgePriority)}");

Console.WriteLine("Press any key to finish");
Console.ReadKey();