using Advent1.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent1
{
    public class ElfStats
    {
        List<List<int>> Stats { get; set; }
        public ElfStats(string input)
        {
            Stats = CalorieParser.Parse(input);
        }

        public int GetHighestCalories(int top = 1)
        {
            return Stats.OrderByDescending(e => e.Sum()).Take(top).Select(e => e.Sum()).Sum();
        }


    }
}
