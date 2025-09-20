using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions.Easy
{
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            //cant be less than 0
            if (x < 0) return false;

            int original = x;
            int reversed = 0;
            while (x > 0)
            {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }
            if (original != reversed) return false;

            return true;
        }

        public bool IsPalindromeAsString(int x)
        {
            string str = x.ToString();
            return str == new string(str.Reverse().ToArray());
        }
    }
}
