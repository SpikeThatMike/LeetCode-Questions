using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            string str = new string([.. s.Where(char.IsLetterOrDigit)]).ToLower();

            return str == new string([.. str.Reverse()]);
        }
    }
}
