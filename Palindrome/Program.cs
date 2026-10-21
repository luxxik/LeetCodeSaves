public class Solution {
    public bool IsPalindrome(int x) {
        string stringedX = Convert.ToString(x);
        string result = "";
        for (int i = stringedX.Length - 1; i >= 0; i--)
        {
            result += stringedX[i];
        }
        if (result == stringedX)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
}