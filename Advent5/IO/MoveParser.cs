using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent5.IO
{
    public static class MoveParser
    {

        public static List<MoveInstruction> FromString(string input)
        {
            List<MoveInstruction> set = new List<MoveInstruction>();
            string[] lines = input.Split(Environment.NewLine);

            foreach (var line in lines)
            {
                string[] data = line.Split(' ');

                MoveInstruction instruction = new MoveInstruction()
                {
                    Quantity = int.Parse(data[1]),
                    TrackFrom = int.Parse(data[3]),
                    TrackTo = int.Parse(data[5])
                };
                set.Add(instruction);

            }
            return set;
        }

    }
}
