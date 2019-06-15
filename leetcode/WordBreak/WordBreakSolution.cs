using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.WordBreak
{
    public class WordBreakSolution
    {
        private HashSet<string> hashDictionary;
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            hashDictionary = new HashSet<string>(wordDict);
            if (string.IsNullOrEmpty(s) || wordDict.Count == 0) return new List<string>();
            return Util(s, new Dictionary<string, List<string>>());
        }

        private List<string> Util(string s, Dictionary<string, List<string>> cache)
        {
            if (cache.ContainsKey(s)) return cache[s];
            List<string> list = new List<string>();
            if (hashDictionary.Contains(s))
                list.Add(s);
            for (int i = 0; i <= s.Length; i++)
            {
                var substring = s.Substring(0, i);
                if (hashDictionary.Contains(substring))
                {
                    var result = Util(s.Substring(i), cache);
                    foreach (var item in result)
                    {
                        list.Add(substring + " " + item);
                    }
                }
            }
            cache.Add(s, list);
            return list;
        }
    }
}
