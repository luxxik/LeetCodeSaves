public class Solution {
    public int RomanToInt(string s) {
        int number = s.Length;
        int total = 0;
        int prevVal = 0;
        for (int i = number - 1; i >= 0; i--)
        {
            int currentSum = 0;
            char n = s[i];
            switch (n)
            {
                case 'I': currentSum = 1; break;
                case 'V': currentSum = 5; break;
                case 'X': currentSum = 10; break;
                case 'L': currentSum = 50; break;
                case 'C': currentSum = 100; break;
                case 'D': currentSum = 500; break;
                case 'M': currentSum = 1000; break;
            }
            if (currentSum < prevVal)
            {
                total -= currentSum;
            }
            else 
            {
                total += currentSum;
            }
            prevVal = currentSum;
        }
        return total;
    }
}