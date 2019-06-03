using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.IsAnagram
{
    public class IsAnagramSolution
    {
        public bool IsAnagram(string s, string t)
        {
            if (string.Equals(s, t)) return true;
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t) || s.Length != t.Length) return false;
            var sa = s.ToCharArray();
            Array.Sort(sa);
            var ta = t.ToCharArray();
            Array.Sort(ta);
            for (int i = 0; i < sa.Length; i++)
            {
                if (sa[i] != ta[i]) return false;
            }
            return true;
        }
    }
}
