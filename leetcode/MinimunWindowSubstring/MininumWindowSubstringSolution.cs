using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.MinimunWindowSubstring
{
    public class MininumWindowSubstringSolution
    {
        public string MinWindow(string s, string t)
        {
            var map = new int[256];
            var tArray = t.ToCharArray();
            foreach (char c in t.Distinct<char>())
            {
                map[c - 'A'] = tArray.Count(internalC => internalC == c);
            }

            int minLeft = -1, minLen = int.MaxValue;

            string _ = null;
            var leftPoint = 0;
            var rightPoint = 0;
            var count = 0;
            while (rightPoint < s.Length)
            {
                if (--map[s[rightPoint] - 'A'] >= 0) ++count;
                while (count == t.Length)
                {
                    if (minLen > rightPoint - leftPoint + 1)
                    {
                        minLen = rightPoint - leftPoint + 1;
                        minLeft = leftPoint;
                    }
                    if (++map[s[leftPoint] - 'A'] > 0) --count;
                    leftPoint++;
                }
                rightPoint++;
            }

            return minLeft == -1 ? "" : s.Substring(minLeft, minLen);
        }

        //Time Exceed version. brute solution.
        public string MinWindow2(string s, string t)
        {
            string _ = null;
            for (int i = 0; i < s.Length-t.Length + 1; i++)
            {
                var point = i + t.Length;
                while (point <= s.Length)
                {
                    var substring = s.Substring(i, point - i);
                    var substringLength = substring.Length;
                    var check = true;
                    foreach (char c in t)
                    {
                        if (!substring.Contains(c.ToString()))
                        {
                            check = false;
                            break;
                        }
                        substring = substring.Remove(substring.IndexOf(c), 1);
                    }

                    if (check)
                    {
                        if(_ == null || _.Length > substringLength)
                            _ = s.Substring(i, point - i);
                    }
                    point++;
                }
            }

            return _ ?? string.Empty;
        }

    }
}
