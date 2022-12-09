using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent4.IO
{
    static class CampParser
    {
        public static List<Pair> Parse(string input)
        {
            List<Pair> pairs = new List<Pair>();
            string[] lines = input.Split(Environment.NewLine);
            foreach(var line in lines)
            {
                string[] elfLines = line.Split(',');

                List<Order> orders = new List<Order>();
                foreach(var el in elfLines)
                {
                    string[] range = el.Split('-');
                    Order order = new Order()
                    {
                        Start = int.Parse(range[0]),
                        End = int.Parse(range[1])
                    };
                    orders.Add(order);
                }
                Pair pair = new Pair(orders.ToArray());
                pairs.Add(pair);
            }
            return pairs;
        }
    }
}
