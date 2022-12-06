using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent3
{
    public class Rucksack
    {
        static Dictionary<char, int> CharValues = new Dictionary<char, int>();
        

        public List<char> FirstCompartment { get; set; } = new List<char>();
        public List<char> SecondCompartment { get; set; } = new List<char>();


        public Rucksack()
        {
            
        }

        public int GetMisconfiguredPriority()
        {
            char? item = FirstCompartment.Where(c => SecondCompartment.Contains(c)).FirstOrDefault();
            if (item == null)
                return 0;
            return PriorityEvaluator.GetPriority((char)item);
        }

    }
}
