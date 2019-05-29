using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.FizzBuzz
{
    public class FizzBuzzSolution
    {
        public IList<string> FizzBuzz(int n)
        {
            if (n == 0) return new List<string>();
            var result = new List<string>();
            for (int index = 1; index <= n; index++)
            {
                string push;
                if (index % (3 * 5) == 0) push = "FizzBuzz";
                else if (index % 3 == 0) push = "Fizz";
                else if (index % 5 == 0) push = "Buzz";
                else push = index.ToString();
                result.Add(push);
            }
            return result;
        }
    }
}
