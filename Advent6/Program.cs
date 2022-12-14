// See https://aka.ms/new-console-template for more information
using Advent6;
using Advent6.Resources;

Console.WriteLine("Hello, radio operator!");
Console.WriteLine("Tuning...");
ElfPacketReader reader = new ElfPacketReader(Resource.Input);
Console.WriteLine("Start of stream: " + reader.GetStart());
Console.WriteLine("Press any key to finish");
Console.ReadKey();
