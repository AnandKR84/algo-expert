//https://leetcode.com/problems/valid-parentheses/

using System.Collections.Generic;

namespace AlgoExpert
{
    public class ValidParanthesisProblem
    {
        public bool IsValid(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return true;
            }

            HashSet<char> left = new HashSet<char> { '(', '[','{' };
            HashSet<char> right = new HashSet<char> { ')', ']', '}' };
            IDictionary<char, char> pair = new Dictionary<char, char>
            {
                [')'] = '(',
                ['}'] = '{',
                [']'] = '['
            };

            Stack<char> paranthesisValidator = new Stack<char>();

            for (int i=0; i<s.Length; i++)
            {
                if(left.Contains(s[i]))
                {
                    paranthesisValidator.Push(s[i]);
                    continue;
                }
                if(right.Contains(s[i]))
                {
                    if(paranthesisValidator.Count == 0 || paranthesisValidator.Pop() != pair[s[i]])
                    {
                        return false;
                    }
                }
            }            

            return paranthesisValidator.Count == 0;
        }
    }
}
