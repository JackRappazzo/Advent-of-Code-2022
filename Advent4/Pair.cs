using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent4
{
    public class Pair
    {
        public Order[] Orders { get; set; }


        public Pair(Order[] orders)
        {
            Orders = orders;
        }
        public bool IsRedundant()
        {
            Order[] set = Orders.OrderBy(o => o.Start).ThenByDescending(o => o.End).ToArray();
            Order low = set[0];
            Order high = set[1];
            if (high.Start >= low.Start && high.End <= low.End)
            {
                return true;
            }
            else return false;
        }

        public bool IsOverlapping()
        {
            Order[] set = Orders.OrderBy(o => o.Start).ThenByDescending(o => o.End).ToArray();
            Order low = set[0];
            Order high = set[1];
            if (high.Start >= low.Start && high.Start <= low.End)
            {
                return true;
            }
            else if (high.End >= low.Start && high.End <= low.End)
                return true;
            else return false;

        }
    }
}
