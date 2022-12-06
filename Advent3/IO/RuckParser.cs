using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent3.IO
{
    public static class RuckParser
    {
        public static List<Rucksack> Parse(string input)
        {
            List<Rucksack> rucks = new List<Rucksack>();
            string[] lines = input.Split(Environment.NewLine);
            foreach(var line in lines)
            {
                Rucksack ruck = new Rucksack()
                {
                    FirstCompartment = line.Take(line.Length / 2).ToList(),
                    SecondCompartment = line.Skip(line.Length / 2).Take(line.Length / 2).ToList()
                };
                rucks.Add(ruck);
            }
            return rucks;
        }
    }
}
