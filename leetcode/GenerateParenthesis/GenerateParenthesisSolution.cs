using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.GenerateParenthesis
{
    public class GenerateParenthesisSolution
    {
        private int max;
        public IList<string> GenerateParenthesis(int n)
        {
            if (n == 0) return new List<string>() { "" };
            max = n;
            HashSet<string>  result = new HashSet<string>();
            ParenthesisGenerator(0, 0, "", result);
            return result.ToList();
        }

        private void ParenthesisGenerator(int left, int right, string wip, HashSet<string> list)
        {
            //terminal condition
            if ((left > max) || (right> max) || (right > left)) return;
            if (left == max && right == max)
            {
                if (list.Contains(wip) == false)
                    list.Add(wip);
                return;
            }

            ParenthesisGenerator(left + 1, right, wip + "(", list);
            ParenthesisGenerator(left, right + 1, wip + ")", list);
        }
    }
}
