namespace ipsilon.leetcode;

public class Program {
    public static string MaxSumOfSquares(int num, int sum) {
        // If even filling every position with 9 cannot reach the target sum,
        // no valid number exists.
        if (num * 9 < sum) {
            return "";
        }

        // Greedily determine how many leading 9s can be placed.
        int nineCount = sum / 9;
        // The remaining digit value after placing all the 9s.
        int remainder = sum % 9;

        // Start building the answer with the leading 9s.
        var result = string.Concat(Enumerable.Repeat("9", nineCount));

        // Append the leftover digit (if any) right after the 9s
        // to keep the number as large as possible.
        if (remainder > 0) {
            result += (char)('0' + remainder);
        }

        // Pad the remaining positions with 0s to reach exactly num digits.
        return result.PadRight(num, '0');
    }

    public static void Main() {
        Console.WriteLine($"Maximum Sum of Squaresof Digits: {MaxSumOfSquares(3, 17)}");
    }
}