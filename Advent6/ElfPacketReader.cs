using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent6
{
    class ElfPacketReader
    {
        string _packet;
        public ElfPacketReader(string packet)
        {
            _packet = packet;
        }

        public int GetStart()
        {
            bool startFound = false;
            int count = 3;
            while (!startFound && count < _packet.Length)
            {
                startFound = IsMarker(_packet, count);
                count++;
            }
            if (!startFound)
                return -1;
            else return count;
        }


        bool IsMarker(string input, int position)
        {
            if (position < 3)
                throw new ArgumentOutOfRangeException("Position must be greater than three");
            string segment = input.Substring(position - 3, 4);

            for (int i = 0; i < segment.Length; i++)
            {
                char toCheck = segment[i];
                for(int j=i+1; j<segment.Length; j++)
                {
                    if (segment[j] == toCheck)
                        return false;

                }
            }
            return true;

        }






    }
}
