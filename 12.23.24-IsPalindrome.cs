public class Solution
{
    public bool IsPalindrome(int x)
    {
        if (x < 0 || (x % 10 == 0 && x != 0))
        {
            return false;
        }

        int reversed = 0;
        int original = x;

        while (x > 0)
        {
            int lastDigit = x % 10;
            reversed = reversed * 10 + lastDigit;
            x /= 10;
        }

        // Check if the reversed number matches the original
        return reversed == original;
    }
}
