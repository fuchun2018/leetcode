using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.WildcardMatch
{
    public class WildcardMatchSolution
    {
        public bool IsMatch(string s, string p)
        {
            Stack<char> stack = new Stack<char>();
            foreach (var item in s)
            {
                stack.Push(item);
            }
            for (int i = p.Length; i > 0 ; i--)
            {
                var pattern = p[i - 1];
                if (pattern == '?') stack.Pop();
                else if (pattern == '*')
                {
                    if (p.Length == 1) return true;
                    var endChar = p[i - 2];
                    while (stack.Peek() != endChar) stack.Pop();
                }
                else if (stack.Peek() == pattern) stack.Pop();
                else break;
            }
            return stack.Count == 0;
        }
    }
}
