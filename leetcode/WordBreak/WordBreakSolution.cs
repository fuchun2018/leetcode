using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.WordBreak
{
    public class WordBreakSolution
    {
        private Dictionary<char, List<string>> dictionary;
        public IList<string> WordBreak(string s, IList<string> wordDict)
        {
            var result = new List<string>();
            if (string.IsNullOrEmpty(s) || wordDict.Count == 0) return result;
            dictionary = new Dictionary<char, List<string>>();
            foreach (var item in wordDict)
            {
                if (dictionary.ContainsKey(item[0]))
                {
                    var list = dictionary[item[0]];
                    if (list.Contains(item) != true) dictionary[item[0]].Add(item);
                }
                else
                    dictionary.Add(item[0], new List<string> { item });
            }
            var wip = new List<string>();
            Util(s, 0, wip, result);
            return result;
        }

        private void Util(string s, int cursor, List<string> wip, List<string> result)
        {
            if (cursor == s.Length)
            {
                result.Add(wip.Aggregate((a, b) => a + " " + b));
                return;
            }

            var substring = s.Substring(cursor, s.Length - cursor);
            if (dictionary.ContainsKey(substring[0]) != true) return;
            var list = dictionary[substring[0]].Where(t => s.IndexOf(t) >= 0).ToList();
            foreach (var item in list)
            {
                if (substring.IndexOf(item) == 0)
                {
                    wip.Add(item);
                    Util(s, cursor + item.Length, wip, result);
                    wip.Remove(item);
                }
            }
        }
    }
}
