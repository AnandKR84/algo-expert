//https://leetcode.com/problems/longest-common-prefix/

namespace AlgoExpert
{
    public class LargestCommonPrefixProblem
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string firstString = strs[0];
            if(string.IsNullOrEmpty(firstString))
            {
                return string.Empty;
            }
            int i = 0;
            do
            {
                bool notEqual = false;
                for (int j = 1; j < strs.Length; j++)
                {
                    string currString = strs[j];
                    if (i >= currString.Length || firstString[i] != currString[i])
                    {
                        notEqual = true;
                        break;
                    }
                }
                if(notEqual)
                {                    
                    break; 
                }
                ++i;
            } while (i < firstString.Length);

            if(i>0)
            {
                return firstString.Substring(0, i);
            }
            return string.Empty;
        }
    }
}
