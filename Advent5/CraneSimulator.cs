using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Advent5
{
    public class CraneSimulator
    {
        IEnumerable<MoveInstruction> _instructions;
        List<char[]> _tracks;

        public CraneSimulator(IEnumerable<MoveInstruction> instructions, List<char[]> tracks)
        {
            _instructions = instructions;
            _tracks = tracks;
        }

        public List<char[]> GetSimulatedResults()
        {
            foreach (var instr in _instructions)
            {
                ExecuteInstruction(instr);
            }
            return _tracks;
        }

        private void ExecuteInstruction(MoveInstruction instr)
        {
            char[] from = _tracks[instr.TrackFrom - 1];
            char[] to = _tracks[instr.TrackTo - 1];
            IEnumerable<char> shift = from.TakeLast(instr.Quantity);
            from = from.SkipLast(instr.Quantity).ToArray();

            to = to.Concat(shift).ToArray();

            _tracks[instr.TrackFrom - 1] = from;
            _tracks[instr.TrackTo - 1] = to;

        }
    }
}
