// See https://aka.ms/new-console-template for more information
using Advent5;
using Advent5.IO;
using Advent5.Resources;
using System;


Console.WriteLine("Hello, movers!");

string[] tracks = new string[]
{
    "FCPGQR", "WTCP", "BHPMC", "LTQSMPR",
    "PHJZVGN", "DPJ", "LGPZFJTR", "NLHCFPTJ",
    "GVZQHTCW"
};


Console.WriteLine("Loading instructions...");
List<MoveInstruction> instructions = MoveParser.FromString(Resource.Input);

CraneSimulator simulator = new CraneSimulator(instructions, tracks.Select(t => t.ToCharArray()).ToList());

List<char[]> finalTracks = simulator.GetSimulatedResults();
string output = string.Join("", finalTracks.Select(c => c.Last()));
Console.WriteLine("Final: " + output);
Console.WriteLine("Press any key to finish");
Console.ReadKey();





