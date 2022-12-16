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
                startFound = IsPacketStart(_packet, count);
                count++;
            }
            if (!startFound)
                return -1;
            else return count;
        }

        public int GetMessageStart(int position = 0)
        {
            bool startFound = false;
            int count = position;
            while (!startFound && count < _packet.Length)
            {
                startFound = IsMessageStart(_packet, count);
                count++;
            }
            if (!startFound)
                return -1;
            else return count;
        }


        bool IsMarker(string input, int position, int size = 4)
        {
            if (position < (size-1))
                throw new ArgumentOutOfRangeException($"Position must be greater than {size -1}");
            string segment = input.Substring(position - (size-1), size);

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

        bool IsPacketStart(string input, int position)
        {
            return IsMarker(input, position, 4);
        }

        bool IsMessageStart(string input, int position)
        {
            return IsMarker(input, position, 14);
        }





    }
}
