using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent3
{
    internal class ElfGroup
    {
        public List<Rucksack> Rucksacks { get; set; }

        public ElfGroup(List<Rucksack> rucksacks)
        {
            if (rucksacks.Count != 3)
                throw new ArgumentException("Argument 'rucksacks' must have a count of 3");
            Rucksacks = rucksacks;
        }

        private int _badgePriority = 0;

        public int BadgePriority
        {
            get
            {
                if (_badgePriority == 0)
                    _badgePriority = SetBadgePriority();
                return _badgePriority;
            }
            set { _badgePriority = value; }
        }

        private int SetBadgePriority()
        {
            Rucksack first = Rucksacks[0];
            char badge = GetFullContents(first).Where(c =>
            {
                return (GetFullContents(Rucksacks[1]).Contains(c) && GetFullContents(Rucksacks[2]).Contains(c));
            }).First();
            return PriorityEvaluator.GetPriority(badge);
        }

        private IEnumerable<char> GetFullContents(Rucksack ruck)
        {
            return ruck.FirstCompartment.Concat(ruck.SecondCompartment);
        }


    }
}
