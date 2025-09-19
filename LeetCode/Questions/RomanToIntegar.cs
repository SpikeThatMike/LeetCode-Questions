using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Questions
{
    public class RomanToIntegar
    {
        public Dictionary<string, int> _conversions = new Dictionary<string, int>
        {
            {"I", 1},
            {"V", 5},
            {"X", 10},
            {"L", 50},
            {"C", 100},
            {"D", 500},
            {"M", 1000}
        };

        public Dictionary<string, int> _specialConversions = new Dictionary<string, int>
        {
            {"IV", 4},
            {"IX", 9},
            {"XL", 40},
            {"XC", 90},
            {"CD", 400},
            {"CM", 900}
        };

        public int RomanToInt(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            for (int i = 0; i < s.Length; i++)
            {
                var character = s[i].ToString();
                var trailingCharacter = i + 1 < s.Length ? s[i + 1].ToString() : "";

                if (_specialConversions.TryGetValue(character + trailingCharacter, out int value))
                {
                    return value + RomanToInt(s.Substring(i + 2, s.Length - 2));
                }
                else
                {
                    if (_conversions.TryGetValue(character.ToString(), out int value2))
                    {
                        return value2 + RomanToInt(s.Substring(i + 1, s.Length - 1));
                    }
                }
            }

            return 0;
        }
    }
}
