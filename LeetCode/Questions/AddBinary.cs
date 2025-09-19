using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    public class AddBinary
    {
        public string BinaryAddition(string a, string b)
        {
            string result = string.Empty;
            int carry = 0;

            a = new string([.. a.Reverse()]);
            b = new string([.. b.Reverse()]);

            for(int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                var digitA = (i < a.Length) ? a[i] - '0' : 0;
                var digitB = (i < b.Length) ? b[i] - '0' : 0;

                var total = digitA + digitB + carry;
                var mod = (total % 2).ToString();

                result = mod + result;
                carry = total / 2;
            }

            if (carry != 0)
            {
                result = carry + result;
            }

            return result;
        }
    }
}
