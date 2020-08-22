using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.LetterCombinationPhoneNumber
{
    public class LetterCombinationPhoneNumberSolution
    {
        public IList<string> LetterCombinations(string digits)
        {
            var dictionary = new Dictionary<char, string>
            {
                {'2', "abc"},
                {'3', "def"},
                {'4', "ghi"},
                {'5', "jkl"},
                {'6', "mno"},
                {'7', "pqrs"},
                {'8', "tvu"},
                {'9', "wxyz"},
            };
            return GenerateCombination(digits, 0, dictionary, new List<string>());
        }

        private IList<string> GenerateCombination(string digits, int position, IDictionary<char, string> dictionary, IList<string> combinationList)
        {
            var result = new List<string>();
            if (position > digits.Length - 1) return combinationList;
            char key = digits[position];

            if (!dictionary.ContainsKey(key)) return GenerateCombination(digits, position+1, dictionary, combinationList);
            var addOn = dictionary[digits[position]];
            foreach (char c in addOn)
            {
                if (combinationList.Count == 0)
                {
                    result.Add(c.ToString());
                }
                else
                {
                    foreach (string s in combinationList)
                    {
                        result.Add(string.Join("", s, c));
                    }
                }
            }

            return GenerateCombination(digits, position + 1, dictionary, result);
        }
    }
}
