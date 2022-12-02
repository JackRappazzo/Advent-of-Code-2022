using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent1.IO
{
    public static class CalorieParser
    {

        public static List<List<int>> Parse(string input)
        {
            string[] lines = input.Split(Environment.NewLine);

            List<List<int>> output = new List<List<int>>();

            int counter = 0;
            foreach (var l in lines)
            {
                int value;
                if (int.TryParse(l, out value))
                {
                    if (output.Count < counter + 1)
                    {
                        output.Add(new List<int>());
                    }
                    output[counter].Add(value);

                }else
                {
                    counter++;
                }
            }
            return output;


        }




    }
}
