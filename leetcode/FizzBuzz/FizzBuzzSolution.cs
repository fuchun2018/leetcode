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
            if (n == 0) return new string[] { };
            var result = new string[n];
            for (int index = 1; index <= n; index++)
            {
                if (index % (3 * 5) == 0) result[index-1]  = "FizzBuzz";
                else if (index % 3 == 0) result[index-1] ="Fizz";
                else if (index % 5 == 0) result[index-1] = "Buzz";
                else result[index-1] = index.ToString();
            }
            return result;
        }
    }
}
