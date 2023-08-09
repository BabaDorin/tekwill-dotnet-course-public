namespace Lectia23_1
{
    public class StringUtils
    {
        public string Reverse(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public bool IsPalindrome(string input)
        {
            string cleanedInput = input.ToLower().Replace(" ", "");
            string reversedInput = Reverse(cleanedInput);
            return cleanedInput == reversedInput;
        }
    }
}
