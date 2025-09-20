using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions.Easy
{
    public class ArrangingCoins
    {
        public int ArrangeCoins(int n)
        {
            int rows = 0;

            while (true)
            {
                rows++;
                n -= rows;
                if (n < 0) return rows - 1;
            }
        }
    }
}
