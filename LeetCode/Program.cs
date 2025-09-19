

using LeetCode.Questions;

//RomanToIntegar romanToIntegar = new RomanToIntegar();
//Console.WriteLine(romanToIntegar.RomanToInt("III")); // Output: 3
//Console.WriteLine(romanToIntegar.RomanToInt("LVIII")); // Output: 58
//Console.WriteLine(romanToIntegar.RomanToInt("MCMXCIV")); // Output: 1994


//LengthOfLastWord lengthOfLastWord = new LengthOfLastWord();
//Console.WriteLine(lengthOfLastWord.LastWordLength("Hello World")); // Output: 5
//Console.WriteLine(lengthOfLastWord.LastWordLength("   fly me   to   the moon  ")); // Output: 4
//Console.WriteLine(lengthOfLastWord.LastWordLength("luffy is still joyboy")); // Output: 6


//BestTimeToBuyAndSellStock bestTimeToBuyAndSellStock = new BestTimeToBuyAndSellStock();
//Console.WriteLine(bestTimeToBuyAndSellStock.MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 })); // Output: 5
//Console.WriteLine(bestTimeToBuyAndSellStock.MaxProfit(new int[] { 7, 6, 4, 3, 1 })); // Output: 0


//AddBinary addBinary = new AddBinary();
//Console.WriteLine(addBinary.BinaryAddition("11", "1")); // Output: "100"
//Console.WriteLine(addBinary.BinaryAddition("1010", "1011")); // Output: "10101"


//TextJustification textJustification = new TextJustification();
//var result = textJustification.FullJustify(["This", "is", "an", "example", "of", "text", "justification."], 16);
//var result2 = textJustification.FullJustify(["What", "must", "be", "acknowledgment", "shall", "be"], 16);
//var result3 = textJustification.FullJustify(["Science", "is", "what", "we", "understand", "well", "enough", "to", "explain", "to", "a", "computer.", "Art", "is", "everything", "else", "we", "do"], 20);
//foreach (var line in result) { Console.WriteLine($"'{line}'"); }
//foreach (var line in result2) { Console.WriteLine($"'{line}'"); }
//foreach (var line in result3) { Console.WriteLine($"'{line}'"); }


//MedianOfTwoSortedArrays medianOfTwoSortedArrays = new MedianOfTwoSortedArrays();
//Console.WriteLine(medianOfTwoSortedArrays.FindMedianSortedArrays([1, 3], [2])); // Output: 2.0
//Console.WriteLine(medianOfTwoSortedArrays.FindMedianSortedArrays([1, 2], [3, 4])); // Output: 2.5


//PalindromeNumber palindromeNumber = new PalindromeNumber();
//Console.WriteLine(palindromeNumber.IsPalindrome(121)); // Output: true
//Console.WriteLine(palindromeNumber.IsPalindrome(-121)); // Output: false
//Console.WriteLine(palindromeNumber.IsPalindrome(10)); // Output: false

//Console.WriteLine(palindromeNumber.IsPalindromeAsString(121)); // Output: true
//Console.WriteLine(palindromeNumber.IsPalindromeAsString(-121)); // Output: false
//Console.WriteLine(palindromeNumber.IsPalindromeAsString(10)); // Output: false


//ValidPalindrome validPalindrome = new ValidPalindrome();
//Console.WriteLine(validPalindrome.IsPalindrome("A man, a plan, a canal: Panama")); // Output: true
//Console.WriteLine(validPalindrome.IsPalindrome("race a car")); // Output: false
//Console.WriteLine(validPalindrome.IsPalindrome(" ")); // Output: true


//ArrangingCoins arrangingCoins = new ArrangingCoins();
//Console.WriteLine(arrangingCoins.ArrangeCoins(5)); // Output: 2
//Console.WriteLine(arrangingCoins.ArrangeCoins(8)); // Output: 3


ValidateIPAddress validateIPAddress = new ValidateIPAddress();
Console.WriteLine(validateIPAddress.ValidIpAddress("172.16.254.1")); // Output: "IPv4"
Console.WriteLine(validateIPAddress.ValidIpAddress("2001:0db8:85a3:0:0:8A2E:0370:7334")); // Output: "IPv6"
Console.WriteLine(validateIPAddress.ValidIpAddress("256.256.256.256")); // Output: "Neither"
//Additional test cases
Console.WriteLine(validateIPAddress.ValidIpAddress("172.16.254.1e1")); // Output: "Neither"
Console.WriteLine(validateIPAddress.ValidIpAddress("172.16.254.01")); // Output: "Neither"
Console.WriteLine(validateIPAddress.ValidIpAddress("20EE:FGb8:85a3:0:0:8A2E:0370:7334")); // Output: "Neither"