using LeetCode.Questions.Easy;
using LeetCode.Questions.Hard;
using LeetCode.Questions.Medium;

namespace LeetCode.Tests
{
    [TestClass]
    public class LeetCodeTests
    {
        [DataTestMethod]
        [DataRow("III", 3)]
        [DataRow("LVIII", 58)]
        [DataRow("MCMXCIV", 1994)]
        public void RomanToIntegar(string input, int expected)
        {
            var roman = new RomanToIntegar();
            Assert.AreEqual(expected, roman.RomanToInt(input));
        }

        [DataTestMethod]
        [DataRow("Hello World", 5)]
        [DataRow("   fly me   to   the moon  ", 4)]
        [DataRow("luffy is still joyboy", 6)]
        public void LengthOfLastWord(string input, int expected)
        {
            var lengthOfLastWord = new LengthOfLastWord();
            Assert.AreEqual(expected, lengthOfLastWord.LastWordLength(input));
        }

        [DataTestMethod]
        [DataRow(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [DataRow(new[] { 7, 6, 4, 3, 1 }, 0)]
        public void BestTimeToBuyAndSellStock(int[] prices, int expected)
        {
            var stock = new BestTimeToBuyAndSellStock();
            Assert.AreEqual(expected, stock.MaxProfit(prices));
        }

        [DataTestMethod]
        [DataRow("11", "1", "100")]
        [DataRow("1010", "1011", "10101")]
        public void BinaryAddition(string a, string b, string expected)
        {
            var addBinary = new AddBinary();
            Assert.AreEqual(expected, addBinary.BinaryAddition(a, b));
        }

        [DataTestMethod]
        [DataRow(new[] { 1, 3 }, new[] { 2 }, 2.0)]
        [DataRow(new[] { 1, 2 }, new[] { 3, 4 }, 2.5)]
        public void FindMedianSortedArrays(int[] nums1, int[] nums2, double expected)
        {
            var median = new MedianOfTwoSortedArrays();
            Assert.AreEqual(expected, median.FindMedianSortedArrays(nums1, nums2));
        }

        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        public void IsPalindrome(int input, bool expected)
        {
            var palindrome = new PalindromeNumber();
            Assert.AreEqual(expected, palindrome.IsPalindrome(input));
        }

        [DataTestMethod]
        [DataRow(121, true)]
        [DataRow(-121, false)]
        [DataRow(10, false)]
        public void IsPalindromeAsString(int input, bool expected)
        {
            var palindrome = new PalindromeNumber();
            Assert.AreEqual(expected, palindrome.IsPalindromeAsString(input));
        }

        [DataTestMethod]
        [DataRow("A man, a plan, a canal: Panama", true)]
        [DataRow("race a car", false)]
        [DataRow(" ", true)]
        public void ValidPalindrome(string input, bool expected)
        {
            var validator = new ValidPalindrome();
            Assert.AreEqual(expected, validator.IsPalindrome(input));
        }

        [DataTestMethod]
        [DataRow(5, 2)]
        [DataRow(8, 3)]
        public void ArrangeCoins(int input, int expected)
        {
            var coins = new ArrangingCoins();
            Assert.AreEqual(expected, coins.ArrangeCoins(input));
        }

        [DataTestMethod]
        [DataRow("172.16.254.1", "IPv4")]
        [DataRow("2001:0db8:85a3:0:0:8A2E:0370:7334", "IPv6")]
        [DataRow("256.256.256.256", "Neither")]
        [DataRow("172.16.254.1e1", "Neither")]
        [DataRow("172.16.254.01", "Neither")]
        [DataRow("20EE:FGb8:85a3:0:0:8A2E:0370:7334", "Neither")]
        public void ValidIpAddress(string input, string expected)
        {
            var validator = new ValidateIPAddress();
            Assert.AreEqual(expected, validator.ValidIpAddress(input));
        }
    }
}
