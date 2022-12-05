// See https://aka.ms/new-console-template for more information
using Advent2;
using Advent2.Game;
using Advent2.IO;
using System.Reflection;

Console.WriteLine("Hello, Rock, Paper, Scissors!");

List<Play> plays = GameParser.GetPlays(Resources.Input);

Console.WriteLine($"Total score = {plays.Select(p => p.GetScore()).Sum()}");
Console.WriteLine("Press any key to finish");
Console.ReadKey();
