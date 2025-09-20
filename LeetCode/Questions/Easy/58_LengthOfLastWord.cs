using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions.Easy
{
    public class LengthOfLastWord
    {
        public int LastWordLength(string s)
        {
            return s.TrimEnd().Split(' ').LastOrDefault().Length;
        }
    }
}
