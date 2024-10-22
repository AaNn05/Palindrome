using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class Palindrome
    {
        public static bool checker(string word, int n, bool result)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == word[n - 1] && n >= 0)
                {
                    n = n - 1;
                }
                else
                {
                    result = false;
                    break;
                }
            }
            
            return result;
        }
    }
}
